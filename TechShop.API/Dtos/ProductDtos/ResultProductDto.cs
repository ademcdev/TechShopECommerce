namespace TechShop.API.Dtos.ProductDtos
{
    public class ResultProductDto
    {
        public int ProductId { get; set; }

        public required string ProductTitle { get; set; }

        public decimal ProductPrice { get; set; }

        public int ProductQuantity { get; set; }

        public int ProductBrand { get; set; }

        public int ProductCategory { get; set; }

        public int ProductSubCategory { get; set; }
    }
}
