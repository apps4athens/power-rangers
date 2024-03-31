using Integration.Google;

namespace Domain
{
    public class Bin
    {
        public int Id { get; set; }
        public double Latitude { get; set; }
        public double Longtitude { get; set; }

        public double Weight { get; set; }
        public double? Volume { get; set; }

        public void SetMetrics(double weight, double? volume = null)
        {
            Weight = weight;
            Volume = volume;
        }

        public void Reset()
        {
            SetMetrics(0, 0);
        }

        public PointOnMap ToPointOnMap()
        {
            return new PointOnMap()
            {
                Latitude = Latitude,
                Longtitude = Longtitude
            };
        }


        public bool ShouldPickUp()
        {
            if (Volume != null && Volume >= MetricConstants.VolumeThreshold)
            {
                return true;
            }
            return Weight >= MetricConstants.WeightThreshold;
        }
    }
}
