using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechShop.API.Dtos.DtosCategory;
using TechShop.API.Repos.CategoryRepos;

namespace TechShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly CategoryInterface _categoryClass;

        public CategoriesController(CategoryInterface categoryClass)
        {
            _categoryClass = categoryClass;
        }

        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            var values = await _categoryClass.GetAllCategoryAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
        {
            _categoryClass.CreateCategory(createCategoryDto);
            return Ok("Kategori başarılı bir şekilde eklendi!");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            _categoryClass.DeleteCategory(id);
            return Ok("Kategori başarılı bir şekilde silindi!");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            _categoryClass.UpdateCategory(updateCategoryDto);
            return Ok("Kategori başarıyla güncellendi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var value = await _categoryClass.GetCategory(id);
            return Ok(value);
        }
    }
}
