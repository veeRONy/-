using p_ch_m_i.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace p_ch_m_i.Controllers
{
    public interface IRepository
    {
        IEnumerable<OrderModel> GetAllOrders();
        IEnumerable<ProductModel> GetAllProducts();
        IEnumerable<ProviderModel> GetAllProviders();
        IEnumerable<SuppliesModel> GetAllSupplies();
        IEnumerable<PurchaseModel> GetAllPurchases();
        IEnumerable<SendingModel> GetAllSendings();

        void DeleteProduct(int id);
        void DeleteProvider(int id);
        void AddOform(PurchaseModel model);



    }
}
