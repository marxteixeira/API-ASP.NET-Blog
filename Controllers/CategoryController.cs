using Blog.Data;
using Blog.Models;
using Blog.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blog.Controllers
{
    public class CategoryController : ControllerBase
    {
        [HttpGet("v1/categories")]
        public async Task<IActionResult> GetAsync(
            [FromServices] BlogDataContext context)
        {
            try
            {
                var categories = await context.Categories.ToListAsync();
                return Ok(categories);
            }
            catch
            {
                return StatusCode(500, "Falha no servidor.");

            }
        }

        [HttpGet("v1/categories/{id}")] // removi :int
        public async Task<IActionResult> GetByIdAsync(
            [FromRoute] int id,
            [FromServices] BlogDataContext context)
        {
            try
            {
                var category = await context
                .Categories
                .FirstOrDefaultAsync(x => x.Id == id);

                if (category == null)
                    return NotFound();

                return Ok(category);
            }
            catch
            {
                return StatusCode(500, "Falha no servidor.");

            }
        }

        [HttpPost("v1/categories")]
        public async Task<IActionResult> PostAsync(
            [FromBody] CreateCategoryViewModels model,
            [FromServices] BlogDataContext context)
        {
            try
            {
                var category = new Category
                {
                    Name = model.Name,
                    Slug = model.Slug.ToLower(),
                };
                await context.Categories.AddAsync(category);
                await context.SaveChangesAsync();

                return Created($"v1/categories/{category.Id}", model);
            }

            catch (DbUpdateException e)
            {
                return StatusCode(500, "Falha no servidor.");
            }
            catch(Exception e)
            {
                return StatusCode(500, "Falha no servidor.");
            }
        }

        [HttpPut("v1/categories/{Id}")] // removi :int
        public async Task<IActionResult> PutAsync(
            [FromRoute] int id,
            [FromBody] Category model,
            [FromServices] BlogDataContext context)
        {
            try
            {
                var category = context.Categories.FirstOrDefault(x => x.Id == id);

                if (category == null)
                    return NotFound();
                category.Name = model.Name;
                category.Slug = model.Slug;

                context.Categories.Update(category);
                await context.SaveChangesAsync();

                return Ok(model);
            }
            catch
            {
                return StatusCode(500, "Falha no servidor.");

            }
        }

        [HttpDelete("v1/categories/{Id}")] // removi :int
        public async Task<IActionResult> DeleteAsync(
            [FromRoute] int id,
            [FromServices] BlogDataContext context)
        {
            try
            {
                var category = context.Categories.FirstOrDefault(x => x.Id == id);

                if (category == null)
                    return NotFound();


                context.Categories.Remove(category);
                await context.SaveChangesAsync();

                return Ok(category);
            }
            catch
            {
                return StatusCode(500, "Falha no servidor.");
            }
        }


    }
}
