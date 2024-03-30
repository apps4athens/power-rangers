using System.Text.Json;
using System.Text.Json.Serialization;
using Domain.Input;

namespace Domain
{
    public class BinCollection
    {
        [JsonPropertyName("bins")]
        public List<Bin> BinList { get; set; } = new();

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
            return result;
        }

    }
}
