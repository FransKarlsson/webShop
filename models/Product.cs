namespace webbShop.models
{
    public class Product
    {
        public string title {get; set;}
        public List<string> images {get; set;}
        public int ID {get; set;}
        public double rating {get; set;}
        public List<Review> Reviews {get; set;}
        public double cost {get; set;}
        public int stock {get; set;}
        public string description {get; set;}
        public List<string> keywords {get; set;}

    }
}