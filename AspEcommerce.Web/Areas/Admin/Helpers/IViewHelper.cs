using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspEcommerce.Web.Areas.Admin.Helpers
{
    public interface IViewHelper
    {
        string GetCategoryParentMapping(Guid categoryId);
        SelectList GetParentCategorySelectList(Guid idToExclude = default(Guid));

        SelectList GetCategorySelectList();

        SelectList GetManufacturerSelectList();

        SelectList GetSpecificationKeySelectList();
    }
}
