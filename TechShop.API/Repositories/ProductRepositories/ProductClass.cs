using Dapper;
using TechShop.API.Dtos.DtosCategory;
using TechShop.API.Dtos.ProductDtos;
using TechShop.API.Models.DapperContext;

namespace TechShop.API.Repositories.ProductRepositories
{
    public class ProductClass : ProductInterface
    {
        private readonly DbContext _dbContext;

        public ProductClass(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<ResultProductDto>> GetAllProductAsync()
        {
            string query = "SELECT * FROM Product";

            using (var connection = _dbContext.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductWithNamesDto>> GetAllProductWithNamesAsync()
        {
            string query = "SELECT ProductId, ProductTitle, ProductPrice, ProductCoverImage, ProductQuantity, ProductDesc, BrandName, CategoryName, SubCategoryName FROM Product INNER JOIN Category ON Product.ProductCategory = Category.CategoryId INNER JOIN Brand ON Product.ProductBrand = Brand.BrandId INNER JOIN SubCategory ON Product.ProductSubCategory = SubCategory.SubCategoryId";

            using (var connection = _dbContext.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductWithNamesDto>(query);
                return values.ToList();
            }
        }
    }
}
