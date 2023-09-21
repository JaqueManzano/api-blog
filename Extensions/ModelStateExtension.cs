using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Blogv2.Extensions
{
    public static class ModelStateExtension 
    {
        public static List<String> GetErrors(this ModelStateDictionary modelState)
        {
            var result = new List<String>();
            foreach (var item in modelState.Values)
                result.AddRange(item.Errors.Select(x => x.ErrorMessage));

            return result;
        }
    }
}
