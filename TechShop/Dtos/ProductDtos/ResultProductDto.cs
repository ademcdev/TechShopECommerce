namespace TechShop.UI.Dtos.ProductDtos
{
    public class ResultProductDto
    {
        public int ProductId { get; set; }

        public required string ProductTitle { get; set; }

        public decimal ProductPrice { get; set; }

        public required string ProductCoverImage { get; set; }

        public int ProductQuantity { get; set; }

        public required string ProductDescription { get; set; }

        public required string BrandName { get; set; }

        public required string CategoryName { get; set; }

        public required string SubCategoryName { get; set; }
    }
}
