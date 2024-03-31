namespace Integration.Google
{
    //    {
    //    "origin": "49.794150,-84.564514",
    //    "destination": "49.173205,-84.756775",
    //    "provideRouteAlternatives": false,
    //    "avoidHighways": false,
    //    "avoidTolls": false,
    //    "avoidFerries": false,
    //    "waypoints": [
    //        {
    //            "location": "49.244978,-88.146057",
    //            "stopover": true
    //        }
    //    ],
    //    "optimizeWaypoints": false,
    //    "travelMode": "DRIVING"
    //}

    public class DirectionRequest
    {
        public PointOnMap Origin { get; set; }
        public PointOnMap Destination { get; set; }
        public List<PointOnMap> Waypoints { get; set; } = new();
        public bool OptimizeWayPoints = false;
        public string TravelMode = "DRIVING";

        public DirectionRequest(List<PointOnMap> pointsOnMap)
        {
            var origin = pointsOnMap.FirstOrDefault();
            if (origin == null)
            {
                return;
            }
            Origin = origin;
            Destination = pointsOnMap.LastOrDefault();
            for (int i = 1; i < pointsOnMap.Count - 1; i++)
            {
                Waypoints.Add(pointsOnMap[i]);
            }
        }
    }

}
