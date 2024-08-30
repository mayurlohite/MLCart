namespace AspEcommerce.Web.Areas.Admin.Helpers
{
    public interface IDataHelper
    {
        string GenerateSeoFriendlyUrl(ServiceType serviceType, string name, int counter = 0);
        bool CheckForDuplicate(ServiceType serviceType, DataType dataType, string value);
    }
}
