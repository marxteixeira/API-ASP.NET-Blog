using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Blog.Extentions
{
    public static class ModelStateExtension
    {
        public static List<string> GetErrors(this ModelStateDictionary modelState)
        {
            var result = new List<string>();
            foreach(var item in modelState.Values)
            {
                foreach(var error in item.Errors)
                {
                    result.Add(error.ErrorMessage); 
                }
            }
            return result;    
        }
    }
}
