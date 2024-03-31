namespace Integration.Google
{
    public class Route
    {
        public List<PointOnMap> Bounds { get; set; } = new();
        public List<RouteLeg> Legs { get; set; } = new();
    }

    public class RouteLeg
    {
        public double Distance { get; set; }
        public double Duration { get; set; }
        public string EndAddress { get; set; }
        public PointOnMap EndLocation { get; set; } = new();
        public string StartAddress { get; set; }
        public PointOnMap StartLocation { get; set; } = new();

        public List<RouteStep> Steps { get; set; } = new();

    }
}