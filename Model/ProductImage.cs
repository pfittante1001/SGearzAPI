namespace SGearzAPI.API.Model
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string ImageName { get; set; }
        public bool IsMain { get; set; }
        public byte[] Image { get; set; }
        public Product Product { get; set; }
        public int ProductID { get; set; }
    }
}