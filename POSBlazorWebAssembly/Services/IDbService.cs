using POSBlazorWebAssembly.Models;

namespace POSBlazorWebAssembly.Services
{
    // Database လုပ်ဆောင်ချက်များအတွက် Interface
    public interface IDbService
    {
        // ကုန်ပစ္စည်း စာရင်းကို ရယူရန်
        Task<List<ProductCreationDataModel>> GetProductList();

        // ကုန်ပစ္စည်း အသစ် သိမ်းဆည်းရန်
        Task SetProduct(ProductCreationDataModel model);
    }
}
