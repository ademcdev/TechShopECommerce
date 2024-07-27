namespace TechShop.API.Dtos.DtosCategory
{
    public class GetByIdCategoryDto
    {
        public int CategoryId { get; set; }

        public required string CategoryName { get; set; }

        public required bool CategoryStatus { get; set; }
    }
}
