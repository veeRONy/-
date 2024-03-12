using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_ch_m_i.Models
{
    public class PurchaseModel
    {
        private int purchase_id;
        private string purchase_date;
        private int product_id;
        private string quantity;
        private string total_price;
        private int provider_id;

        [DisplayName("Регистрационный номер")]
        public int Purchase_id { get => purchase_id; set => purchase_id = value; }

        [DisplayName("Дата")]
        [Required(ErrorMessage = "Требуется дата")]
        public string Purchase_date { get => purchase_date; set => purchase_date = value; }

        [DisplayName("Код товара")]
        [Required(ErrorMessage = "Требуется код товара")]
        public int Product_id { get => product_id; set => product_id = value; }

        [DisplayName("Количество")]
        [Required(ErrorMessage = "Требуется количество")]
        public string Quantity { get => quantity; set => quantity = value; }

        [DisplayName("Код поставщика")]
        [Required(ErrorMessage = "Требуется код поставщика")]
        public int Provider_id { get => provider_id; set => provider_id = value; }

        [DisplayName("Итоговая стоимость")]
        [Required(ErrorMessage = "Требуется итоговая стоимость")]
        public string Total_price { get => total_price; set => total_price = value; }
    }
}
