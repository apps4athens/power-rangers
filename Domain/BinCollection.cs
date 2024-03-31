using System.Text.Json;
using System.Text.Json.Serialization;
using Domain.Input;
using Integration.Google;

namespace Domain
{
    public class BinCollection
    {
        [JsonPropertyName("bins")]
        public List<Bin> BinList { get; set; } = new();

        private List<Bin> _binListToPickUP;
        private GoogleCLient _googleCLient = new();

        public BinCollection()
        {
        }

        public void InitiliazePoints()
        {
            var path = $"Input{Path.DirectorySeparatorChar}Points.json";
            using StreamReader stream = new(path);
            var json = stream.ReadToEnd();
            var des = JsonSerializer.Deserialize<BinCollection>(json, new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true,
            });
            BinList = des?.BinList;
            SetMetrics();
        }

        private void SetMetrics()
        {
            var path = $"Input{Path.DirectorySeparatorChar}MetricsInput.json";
            using StreamReader stream = new(path);
            var json = stream.ReadToEnd();
            var allmetrics = JsonSerializer.Deserialize<List<Metric>>(json, new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true,
            });

            foreach (var metr in allmetrics)
            {
                BinList.FirstOrDefault(x => x.Id == metr.Id)?.SetMetrics(metr.Weight, metr.Volume);
            }
        }

        public List<Bin> GetBinsToPickUp()
        {
            var result = new List<Bin>();
            foreach (var bin in BinList)
            {
                if (bin.ShouldPickUp())
                    result.Add(bin);
            }
            _binListToPickUP = result;
            return result;
        }


        public async Task<DirectionsResponse> GetDirectionsToBins()
        {
            var points = new List<PointOnMap>();
            foreach (var bin in _binListToPickUP)
            {
                points.Add(bin.ToPointOnMap());
            }
            return await _googleCLient.GetDirectionsAsync(points);
        }
    }
}
