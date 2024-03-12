using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_ch_m_i.Models
{
    public class SuppliesModel
    {
        private int supply_id;
        private string supply_date;
        private string supply_time;
        private int product_id;
        private string quantity;
        private int provider_id;

        [DisplayName("Регистрационный номер")]
        public int Supply_id { get => supply_id; set => supply_id = value; }

        [DisplayName("Дата")]
        [Required(ErrorMessage = "Требуется указать дата")]
        public string Supply_date { get => supply_date; set => supply_date = value; }

        [DisplayName("Время")]
        [Required(ErrorMessage = "Требуется указать время")]
        public string Supply_time { get => supply_time; set => supply_time = value; }

        [DisplayName("Код товара")]
        [Required(ErrorMessage = "Требуется указать код товара")]
        public int Product_id { get => product_id; set => product_id = value; }

        [DisplayName("Количество")]
        [Required(ErrorMessage = "Требуется указать количество")]
        public string Quantity { get => quantity; set => quantity = value; }

        [DisplayName("Код поставщика")]
        [Required(ErrorMessage = "Требуется указать код поставщика")]
        public int Provider_id { get => provider_id; set => provider_id = value; }


    }
}
