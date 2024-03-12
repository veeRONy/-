using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_ch_m_i.Models
{
    public class ProviderModel
    {
        private int provider_id;
        private string provider_name;
        private string provider_phone_num;
        private string provider_email;


        [DisplayName("Код поставщика")]
        public int Provider_id { get => provider_id; set => provider_id = value; }

        [DisplayName("Название")]
        [Required(ErrorMessage = "Требуется название")]
        public string Provider_name { get => provider_name; set => provider_name = value; }

        [DisplayName("Телефон")]
        [Required(ErrorMessage = "Требуется телефон")]
        public string Provider_phone_num { get => provider_phone_num; set => provider_phone_num = value; }

        [DisplayName("E-mail")]
        [Required(ErrorMessage = "Требуется e-mail")]
        public string Provider_email { get => provider_email; set => provider_email = value; }
    }
}
