using Blazored.LocalStorage;
using POSBlazorWebAssembly.Models;

namespace POSBlazorWebAssembly.Services
{
    // Browser ၏ Local Storage ကို အသုံးပြု၍ အချက်အလက် သိမ်းဆည်းပေးမည့် Service
    public class LocalStorageService : IDbService
    {
        private readonly ILocalStorageService localStorage;

        public LocalStorageService(ILocalStorageService localStorage)
        {
            this.localStorage = localStorage;
        }

        // ကုန်ပစ္စည်း စာရင်းကို Local Storage မှ ပြန်ထုတ်ယူခြင်း
        public async Task<List<ProductCreationDataModel>> GetProductList()
        {
            // "Tbl_Product" key ဖြင့် သိမ်းထားသော စာရင်းကို ယူခြင်း
            List<ProductCreationDataModel> lst = await localStorage.GetItemAsync<List<ProductCreationDataModel>>("Tbl_Product");
            lst ??= new(); // စာရင်းမရှိပါက အသစ်တစ်ခု ပြုလုပ်ခြင်း
            // နေ့စွဲအလိုက် အသစ်ဆုံးကို အပေါ်ဆုံးက ထား၍ ပြန်ပို့ပေးခြင်း
            return lst.OrderByDescending(x=> x.product_cration_date).ToList();
        }

        // ကုန်ပစ္စည်း အသစ်ကို Local Storage တွင် သိမ်းဆည်းခြင်း
        public async Task SetProduct(ProductCreationDataModel model)
        {
            // ရှိပြီးသား စာရင်းကို အရင်ယူခြင်း
            List<ProductCreationDataModel> lst = await localStorage.GetItemAsync<List<ProductCreationDataModel>>("Tbl_Product");
            lst ??= new();
            // အသစ်ကို စာရင်းထဲသို့ ပေါင်းထည့်ခြင်း
            lst.Add(model);
            // Local Storage တွင် ပြန်လည် သိမ်းဆည်းခြင်း
            await localStorage.SetItemAsync("Tbl_Product", lst);
        }
    }
}
