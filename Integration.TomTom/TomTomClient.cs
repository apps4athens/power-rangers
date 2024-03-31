using CommonModels;

namespace Integration.TomTom
{
    public class TomTomClient
    {
        public async Task<DirectionsResponse> GetDirectionsAsync(List<PointOnMap> pointsOnMap)
        {
            return new DirectionsResponse()
            {
                Routes = new List<Route>(50)
            };
        }
    }
}