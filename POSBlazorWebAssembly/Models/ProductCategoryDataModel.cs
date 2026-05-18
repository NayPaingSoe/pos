namespace POSBlazorWebAssembly.Models
{
    // ကုန်ပစ္စည်း အမျိုးအစား အချက်အလက် Model
    public class ProductCategoryDataModel
    {
        // အမျိုးအစား ID (အလိုအလျောက် ID ထုတ်ပေးမည်)
        public Guid Product_category_id { get; set; } = Guid.NewGuid();
        
        // အမျိုးအစား အမည်
        public string Product_category_name { get; set; }
        
        // အမျိုးအစား ကုဒ်
        public int Product_category_code { get; set; }
    }
}
