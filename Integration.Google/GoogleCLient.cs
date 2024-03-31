using System.Net.Mime;
using System.Text;
using System.Text.Json;
using CommonModels;

namespace Integration.Google
{
    //https://maps.googleapis.com/maps/api/directions/json?origin=Disneyland&destination=Universal+Studios+Hollywood&key=YOUR_API_KEY

    public class GoogleClient
    {
        private string APIKEY = "12jodhncpwy84cfa8";
        private HttpClient _client = new()
        {
            BaseAddress = new Uri("https://maps.googleapis.com"),
        };
        private const string _subPath = "maps/api/directions/json";


        public async Task<DirectionsResponse> GetDirectionsAsync(List<PointOnMap> pointsOnMap)
        {
            var directionsRequest = new DirectionRequest(pointsOnMap);
            var httprequest = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(_subPath + $"?origin={directionsRequest.Origin.ToString()}&destination={directionsRequest.Destination.ToString()}&key={APIKEY}"),
                Content = new StringContent(
                    JsonSerializer.Serialize(directionsRequest),
                    Encoding.UTF8,
                    MediaTypeNames.Application.Json), // or "application/json" in older versions
            };

            var response = await _client.SendAsync(httprequest)
                .ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            return JsonSerializer.Deserialize<DirectionsResponse>(response.Content.ToString());
        }
    }
}
