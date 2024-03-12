using p_ch_m_i.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_ch_m_i.Controllers
{
    public class ProductController:_Validator
    {
        Form1 form;

        public ProductController(Form1 form)
        {
            this.form = form;
            form.DeleteProductEvent += DeleteProduct;
        }

        private void DeleteProduct(object? sender, EventArgs e)
        {
            try
            {
                var prod = (ProductModel)form.productsbindingSource.Current;
                form.repository.DeleteProduct(prod.Product_id);
                form.IsSuccess = true;
                form.Message = "Данные о товаре успешно удалены.";
                form.LoadAllOrderList();
                form.LoadAllSupplyList();
                form.LoadAllProductList();
                form.LoadAllPurchaseList();
            }
            catch
            {
                form.IsSuccess = false;
                form.Message = "Ошибка! Данные о товаре не были удалены.";
            }
        }
    }
}
