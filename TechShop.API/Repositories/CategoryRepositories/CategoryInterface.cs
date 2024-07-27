using TechShop.API.Dtos.DtosCategory;

namespace TechShop.API.Repos.CategoryRepos
{
    public interface CategoryInterface
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();

        void CreateCategory(CreateCategoryDto categoryDto);

        void UpdateCategory(UpdateCategoryDto categoryDto);

        void DeleteCategory(int id);

        Task<GetByIdCategoryDto> GetCategory(int id);
    }
}
