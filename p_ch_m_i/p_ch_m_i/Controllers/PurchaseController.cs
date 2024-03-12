using p_ch_m_i.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_ch_m_i.Controllers
{
    public class PurchaseController:_Validator
    {
        Form1 form;

        public PurchaseController(Form1 form)
        {
            this.form = form;
            form.SaveOformEvent+= SaveOform;
            form.CancelEvent += CancelOform;
            form.AddOformEvent += AddOform;
        }

        private void AddOform(object? sender, EventArgs e)
        {
            CancelOform(sender, e);
        }

        private void CancelOform(object? sender, EventArgs e)
        {
            form.product_id = 0;
            form.provider_id = 0;
            form.quantity = 0;
        }

        private void SaveOform(object? sender, EventArgs e)
        {
            var model = new PurchaseModel();
            model.Product_id = form.product_id;
            model.Provider_id = form.provider_id;
            model.Quantity = form.quantity.ToString();
            model.Purchase_date = DateTime.Now.Date.ToString("dd.MM.yyyy");
            model.Total_price = (GetPrice(model.Product_id) * form.quantity).ToString();
            try
            {
                Validate(model);
                
                form.repository.AddOform(model);
                form.Message = "Закупка успешно оформлена.";
                form.IsSuccess = true;
                form.LoadAllProductList();
                form.LoadAllPurchaseList();
            }
            catch (Exception ex)
            {
                form.IsSuccess = false;
                form.Message = ex.Message;
            }
        }

        private int GetPrice(int id)
        {
            IEnumerable<ProductModel> list = new List<ProductModel>();
            list = form.GetProducts();
            foreach(var prod in list)
            {
                if (prod.Product_id == id)
                    return Convert.ToInt32(prod.Price);
            }
            return 0;
        }
    }
}
