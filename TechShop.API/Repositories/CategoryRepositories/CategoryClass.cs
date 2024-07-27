using Dapper;
using TechShop.API.Dtos.DtosCategory;
using TechShop.API.Models.DapperContext;

namespace TechShop.API.Repos.CategoryRepos
{
    public class CategoryClass : CategoryInterface
    {
        private readonly DbContext _dbContext;

        public CategoryClass(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async void CreateCategory(CreateCategoryDto categoryDto)
        {
            string query = "INSERT INTO Category (CategoryName, CategoryStatus) values (@categoryName, @categoryStatus)";

            var parameters = new DynamicParameters();
            parameters.Add("@categoryName", categoryDto.CategoryName);
            parameters.Add("@categoryStatus", true);

            using (var connection = _dbContext.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteCategory(int id)
        {
            string query = "DELETE FROM Category WHERE CategoryId = @categoryId";

            var parameters = new DynamicParameters();
            parameters.Add("@categoryId", id);

            using (var connection = _dbContext.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultCategoryDto>> GetAllCategoryAsync()
        {
            string query = "SELECT * FROM Category";

            using (var connection = _dbContext.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultCategoryDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIdCategoryDto> GetCategory(int id)
        {
            string query = "SELECT * FROM Category WHERE CategoryId = @categoryId";

            var parameters = new DynamicParameters();
            parameters.Add("@categoryId", id);

            using (var connection = _dbContext.CreateConnection())
            {
                var value = await connection.QueryFirstOrDefaultAsync<GetByIdCategoryDto>(query, parameters);
                return value ?? new GetByIdCategoryDto { CategoryName = string.Empty, CategoryStatus = false };
            }
        }

        public async void UpdateCategory(UpdateCategoryDto categoryDto)
        {
            string query = "UPDATE Category SET CategoryName = @categoryName, CategoryStatus = @categoryStatus WHERE CategoryId = @categoryId";

            var parameters = new DynamicParameters();
            parameters.Add("@categoryName", categoryDto.CategoryName);
            parameters.Add("@categoryStatus", categoryDto.CategoryStatus);
            parameters.Add("@categoryId", categoryDto.CategoryId);

            using (var connection = _dbContext.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
