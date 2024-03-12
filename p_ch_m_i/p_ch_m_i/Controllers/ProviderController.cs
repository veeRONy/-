using p_ch_m_i.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_ch_m_i.Controllers
{
    public class ProviderController:_Validator
    {
        Form1 form;

        public ProviderController(Form1 form)
        {
            this.form = form;
            form.DeleteProviderEvent += DeleteProvider;
        }

        private void DeleteProvider(object? sender, EventArgs e)
        {
            try
            {
                var prov = (ProviderModel)form.providerssbindingSource.Current;
                form.repository.DeleteProvider(prov.Provider_id);
                form.IsSuccess = true;
                form.Message = "Данные поставщика успешно удалены.";
                form.LoadAllPurchaseList();
                form.LoadAllSupplyList();
                form.LoadAllProductList();
            }
            catch
            {
                form.IsSuccess = false;
                form.Message = "Ошибка! Данные поставщика не были удалены.";
            }
        }
    }
}
