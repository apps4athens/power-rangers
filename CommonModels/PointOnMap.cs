namespace CommonModels
{
    public class PointOnMap
    {
        public double Latitude { get; set; }
        public double Longtitude { get; set; }

        public new string ToString()
        {
            return $"{Latitude},{Longtitude}";
        }
    }
}
