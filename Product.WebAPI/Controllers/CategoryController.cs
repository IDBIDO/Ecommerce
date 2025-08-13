using Microsoft.AspNetCore.Mvc;
using Product.Domain.Entity;

namespace Product.WebAPI.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class CategoryController
{
    private readonly ICategoryRepository _categoryRepository;
    
    public CategoryController(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
    
    [HttpGet]
    public async Task<ServiceRespponse<List<Category>>> FindAllCategoriesAsync()
    {
        var resp = new ServiceRespponse<List<Category>>();
        
        var result = await _categoryRepository.FindAllCategoriesAsync();
        
        if (result == null || result.Count == 0)
        {
            resp.Message = "No categories found.";
        }
        else
        {
            resp.Message = "Categories retrieved successfully.";
            resp.Data = result;
        }

        return resp;
    }
    
}