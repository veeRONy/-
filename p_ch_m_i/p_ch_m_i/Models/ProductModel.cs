using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace p_ch_m_i.Models
{
    public class ProductModel
    {
        private int product_id;
        private string product_name;
        private string product_size;
        private string price;
        private string in_stock;
        private string quantity;
        private string category;
        private int provider_id;

        [DisplayName("Код товара")]
        public int Product_id { get => product_id; set => product_id = value; }

        [DisplayName("Название")]
        [Required(ErrorMessage = "Требуется задать название")]
        public string Product_name { get => product_name; set => product_name = value; }

        [DisplayName("Размер (ШхГхВ)")]
        [Required(ErrorMessage = "Требуется задать размер")]
        public string Product_size { get => product_size; set => product_size = value; }

        [DisplayName("Цена, за шт.")]
        [Required(ErrorMessage = "Требуется указать цену")]
        public string Price { get => price; set => price = value; }

        [DisplayName("В наличии")]
        [Required(ErrorMessage = "Требуется указать наличие товара на складе")]
        public string In_stock { get => in_stock; set => in_stock = value; }

        [DisplayName("Количество")]
        [Required(ErrorMessage = "Требуется указать количество")]
        public string Quantity { get => quantity; set => quantity = value; }

        [DisplayName("Категория товара")]
        [Required(ErrorMessage = "Требуется указать категорию товара")]
        public string Category { get => category; set => category = value; }

        [DisplayName("Код поставщика")]
        [Required(ErrorMessage = "Требуется указать код поставщика")]
        public int Provider_id { get => provider_id; set => provider_id = value; }


    }
}
