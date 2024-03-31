namespace CommonModels
{
    public class DirectionsResponse : IComparable<DirectionsResponse>
    {
        public List<Route> Routes { get; set; }

        public int CompareTo(DirectionsResponse? other)
        {
            return Routes.Count().CompareTo(other.Routes.Count());
        }


    }
}
