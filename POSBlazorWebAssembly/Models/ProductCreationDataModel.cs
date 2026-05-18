namespace POSBlazorWebAssembly.Models
{
    // ကုန်ပစ္စည်း အသစ်ထည့်သွင်းရန် အချက်အလက် Model
    public class ProductCreationDataModel
    {
        // ကုန်ပစ္စည်း ID (အလိုအလျောက် ID ထုတ်ပေးမည်)
        public Guid product_id { get; set; } = Guid.NewGuid();

        // ကုန်ပစ္စည်း အမည်
        public string product_name { get; set; }

        // ကုန်ပစ္စည်း ကုဒ် (အလိုအလျောက် ကုဒ် ထုတ်ပေးမည်)
        public Guid product_code { get; set; } = Guid.NewGuid();

        // ကုန်ပစ္စည်း အမျိုးအစား ကုဒ်
        public int product_category_code { get; set; }

        // ရောင်းဈေး
        public int product_sale_price { get; set; }

        // ဝယ်ဈေး
        public int product_buying_price { get; set; }

        // စတင် ထည့်သွင်းသည့် ရက်စွဲ
        public DateTime product_cration_date { get; set; } = new DateTime();
    }
}
