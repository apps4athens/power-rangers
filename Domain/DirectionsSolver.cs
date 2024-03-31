using CommonModels;
using Integration.Google;
using Integration.TomTom;

namespace Domain
{
    public class DirectionsSolver
    {
        private GoogleClient _googleClient = new();
        private TomTomClient _tomtomClient = new();

        internal async Task<DirectionsResponse> GetDirectionsAsync(List<PointOnMap> points)
        {
            var gSolution = await _googleClient.GetDirectionsAsync(points);
            var tomSolution = await _tomtomClient.GetDirectionsAsync(points);

            var compareResult = gSolution.CompareTo(tomSolution);
            if (compareResult < 0)
                return tomSolution;
            else
                return gSolution;

        }
    }

}
