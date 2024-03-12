using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace p_ch_m_i.Models
{
    public class OrderModel
    {
		private int order_id;
		private string order_data;
		private string order_time;
		private int product_id;
		private string quantity;
		private string client_fio;
		private string client_phone_num;
		private string client_email;
		private string status;
		private string sent;

        [DisplayName("Код заказа")]
        public int Order_id { get => order_id; set => order_id = value; }

        [DisplayName("Дата")]
        [Required(ErrorMessage = "Требуется дата")]
        public string Order_data { get => order_data; set => order_data = value; }

        [DisplayName("Время")]
        [Required(ErrorMessage = "Требуется время")]
        public string Order_time { get => order_time; set => order_time = value; }

        [DisplayName("Код товара")]
        [Required(ErrorMessage = "Требуется код товара")]
        public int Product_id { get => product_id; set => product_id = value; }

        [DisplayName("Количество")]
        [Required(ErrorMessage = "Требуется количество товара")]
        public string Quantity { get => quantity; set => quantity = value; }

        [DisplayName("ФИО клиента")]
        [Required(ErrorMessage = "Требуется ФИО клиента")]
        public string Client_fio { get => client_fio; set => client_fio = value; }

        [DisplayName("Телефон")]
        [Required(ErrorMessage = "Требуется телефон")]
        public string Client_phone_num { get => client_phone_num; set => client_phone_num = value; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Требуется email")]
        public string Client_email { get => client_email; set => client_email = value; }

        [DisplayName("Статус оплаты")]
        [Required(ErrorMessage = "Требуется указать статус оплаты")]
        public string Status { get => status; set => status = value; }

        [DisplayName("Отправлено")]
        [Required(ErrorMessage = "Требуется указать статус отправки")]
        public string Sent { get => sent; set => sent = value; }
    }
}
