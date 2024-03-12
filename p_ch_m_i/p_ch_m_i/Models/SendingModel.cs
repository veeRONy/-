using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_ch_m_i.Models
{
    public class SendingModel
    {
        private int sending_id;
        private int product_id;
        private string quantity;
        private string total_price;
        private string delivery_status;


        [DisplayName("Регистрационный номер")]
        public int Sending_id { get => sending_id; set => sending_id = value; }


        [DisplayName("Код товара")]
        [Required(ErrorMessage = "Требуется код товара")]
        public int Product_id { get => product_id; set => product_id = value; }


        [DisplayName("Количество")]
        [Required(ErrorMessage = "Требуется количество")]
        public string Quantity { get => quantity; set => quantity = value; }


        [DisplayName("Итоговая стоимость")]
        [Required(ErrorMessage = "Требуется итоговая стоимость")]
        public string Total_price { get => total_price; set => total_price = value; }

        [DisplayName("Статус доставки")]
        [Required(ErrorMessage = "Требуется статус доставки")]
        public string Delivery_status { get => delivery_status; set => delivery_status = value; }
    }
}
