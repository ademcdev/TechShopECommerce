using TechShop.API.Dtos.ProductDtos;

namespace TechShop.API.Repositories.ProductRepositories
{
    public interface ProductInterface
    {
        Task<List<ResultProductDto>> GetAllProductAsync();

        Task<List<ResultProductWithNamesDto>> GetAllProductWithNamesAsync();
    }
}
