using p_ch_m_i.Controllers;
using p_ch_m_i.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace p_ch_m_i
{
    public partial class Form1 : Form
    {
        public BindingSource ordersbindingSource;
        public BindingSource productsbindingSource;
        public BindingSource providerssbindingSource;
        public BindingSource suppliesbindingSource;
        public BindingSource purchasesbindingSource;
        public BindingSource sendingbindingSource;

        public IRepository repository;

        public IEnumerable<OrderModel> orderList;
        public IEnumerable<ProductModel> productList;
        public IEnumerable<ProviderModel> providerList;
        public IEnumerable<SuppliesModel> suppliesList;
        public IEnumerable<PurchaseModel> purchaseList;
        public IEnumerable<SendingModel> sendingList;
        public Form1()
        {
            InitializeComponent();
            SetBindingSources();
            repository = new Repository(ConfigurationManager.ConnectionStrings["SqliteConnectionString"].ConnectionString);
            tabControl.TabPages.Remove(tabProducts);
            tabControl.TabPages.Remove(tabProviders);
            tabControl.TabPages.Remove(tabSupplies);
            tabControl.TabPages.Remove(tabPurchases);
            tabControl.TabPages.Remove(tabSending);
            tabControl.TabPages.Remove(tabOform);

            orderList = new List<OrderModel>();
            productList = new List<ProductModel>();
            providerList = new List<ProviderModel>();
            suppliesList = new List<SuppliesModel>();
            purchaseList = new List<PurchaseModel>();
            sendingList = new List<SendingModel>();

            new ProductController(this);
            new ProviderController(this);
            new PurchaseController(this);

            LoadAllOrderList();
            LoadAllProductList();
            LoadAllProviderList();
            LoadAllSupplyList();
            LoadAllPurchaseList();
            LoadAllSendingList();

            buttonOrders.Enabled = false;
            buttonGoods.Enabled = true;
            buttonProviders.Enabled = true;
            buttonSupplies.Enabled = true;
            buttonPurchases.Enabled = true;
            buttonSending.Enabled = true;

            buttonOrders.BackColor = Color.MediumSlateBlue;
            buttonGoods.BackColor = Color.FromArgb(51, 51, 76);
            buttonProviders.BackColor = Color.FromArgb(51, 51, 76);
            buttonSupplies.BackColor = Color.FromArgb(51, 51, 76);
            buttonPurchases.BackColor = Color.FromArgb(51, 51, 76);
            buttonSending.BackColor = Color.FromArgb(51, 51, 76);

            btnDeleteProduct.Click += delegate
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить информацию о товаре?", "Warning",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteProductEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            btnDeleteProvider.Click += delegate
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить информацию о поставщике?", "Warning",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteProviderEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl.TabPages.Remove(tabOform);
                tabControl.TabPages.Add(tabProducts);
            };

            btnOformZakupku.Click += delegate
            {
                GetProducts();
                GetProviders();
                AddOformEvent?.Invoke(this, EventArgs.Empty);
                tabControl.TabPages.Add(tabOform);
                tabControl.TabPages.Remove(tabProducts);
            };

            btnOform.Click += delegate
            {
                SaveOformEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccess)
                {
                    tabControl.TabPages.Remove(tabOform);
                    tabControl.TabPages.Add(tabProducts);
                }
                MessageBox.Show(Message);
            };

        }


        public event EventHandler DeleteProductEvent;
        public event EventHandler DeleteProviderEvent;
        public event EventHandler AddOformEvent;
        public event EventHandler SaveOformEvent;
        public event EventHandler CancelEvent;

        public void LoadAllOrderList()
        {
            orderList = repository.GetAllOrders();
            ordersbindingSource.DataSource = orderList;
        }

        public void LoadAllProductList()
        {
            productList = repository.GetAllProducts();
            productsbindingSource.DataSource = productList;
        }

        public void LoadAllProviderList()
        {
            providerList = repository.GetAllProviders();
            providerssbindingSource.DataSource = providerList;
        }

        public void LoadAllSupplyList()
        {
            suppliesList = repository.GetAllSupplies();
            suppliesbindingSource.DataSource = suppliesList;
        }

        public void LoadAllPurchaseList()
        {
            purchaseList = repository.GetAllPurchases();
            purchasesbindingSource.DataSource = purchaseList;
        }

        public void LoadAllSendingList()
        {
            sendingList = repository.GetAllSendings();
            sendingbindingSource.DataSource = sendingList;
        }
        private void SetBindingSources()
        {
            this.ordersbindingSource = new BindingSource();
            dgvOrders.DataSource = ordersbindingSource;
            productsbindingSource = new BindingSource();
            dgvProducts.DataSource = productsbindingSource;
            providerssbindingSource = new BindingSource();
            dgvProviders.DataSource = providerssbindingSource;
            suppliesbindingSource = new BindingSource();
            dgvSupplies.DataSource = suppliesbindingSource;
            purchasesbindingSource = new BindingSource();
            dgvPurchases.DataSource = purchasesbindingSource;
            sendingbindingSource = new BindingSource();
            dgvSendings.DataSource = sendingbindingSource;

        }


        private void buttonOrders_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Add(tabOrders);
            tabControl.TabPages.Remove(tabProducts);
            tabControl.TabPages.Remove(tabProviders);
            tabControl.TabPages.Remove(tabSupplies);
            tabControl.TabPages.Remove(tabPurchases);
            tabControl.TabPages.Remove(tabSending);
            tabControl.TabPages.Remove(tabOform);

            buttonOrders.Enabled = false;
            buttonGoods.Enabled = true;
            buttonProviders.Enabled = true;
            buttonSupplies.Enabled = true;
            buttonPurchases.Enabled = true;
            buttonSending.Enabled = true;

            buttonOrders.BackColor = Color.MediumSlateBlue;
            buttonGoods.BackColor = Color.FromArgb(51, 51, 76);
            buttonProviders.BackColor = Color.FromArgb(51, 51, 76);
            buttonSupplies.BackColor = Color.FromArgb(51, 51, 76);
            buttonPurchases.BackColor = Color.FromArgb(51, 51, 76);
            buttonSending.BackColor = Color.FromArgb(51, 51, 76);

        }

        private void buttonGoods_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Add(tabProducts);
            tabControl.TabPages.Remove(tabOrders);
            tabControl.TabPages.Remove(tabProviders);
            tabControl.TabPages.Remove(tabSupplies);
            tabControl.TabPages.Remove(tabPurchases);
            tabControl.TabPages.Remove(tabSending);
            tabControl.TabPages.Remove(tabOform);

            buttonOrders.Enabled = true;
            buttonGoods.Enabled = false;
            buttonProviders.Enabled = true;
            buttonSupplies.Enabled = true;
            buttonPurchases.Enabled = true;
            buttonSending.Enabled = true;

            buttonGoods.BackColor = Color.MediumSlateBlue;
            buttonOrders.BackColor = Color.FromArgb(51, 51, 76);
            buttonProviders.BackColor = Color.FromArgb(51, 51, 76);
            buttonSupplies.BackColor = Color.FromArgb(51, 51, 76);
            buttonPurchases.BackColor = Color.FromArgb(51, 51, 76);
            buttonSending.BackColor = Color.FromArgb(51, 51, 76);
        }

        private void buttonProviders_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Add(tabProviders);
            tabControl.TabPages.Remove(tabProducts);
            tabControl.TabPages.Remove(tabOrders);
            tabControl.TabPages.Remove(tabSupplies);
            tabControl.TabPages.Remove(tabPurchases);
            tabControl.TabPages.Remove(tabSending);
            tabControl.TabPages.Remove(tabOform);

            buttonOrders.Enabled = true;
            buttonGoods.Enabled = true;
            buttonProviders.Enabled = false;
            buttonSupplies.Enabled = true;
            buttonPurchases.Enabled = true;
            buttonSending.Enabled = true;

            buttonProviders.BackColor = Color.MediumSlateBlue;
            buttonOrders.BackColor = Color.FromArgb(51, 51, 76);
            buttonGoods.BackColor = Color.FromArgb(51, 51, 76);
            buttonSupplies.BackColor = Color.FromArgb(51, 51, 76);
            buttonPurchases.BackColor = Color.FromArgb(51, 51, 76);
            buttonSending.BackColor = Color.FromArgb(51, 51, 76);

        }

        private void buttonSupplies_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Add(tabSupplies);
            tabControl.TabPages.Remove(tabProducts);
            tabControl.TabPages.Remove(tabProviders);
            tabControl.TabPages.Remove(tabOrders);
            tabControl.TabPages.Remove(tabPurchases);
            tabControl.TabPages.Remove(tabSending);
            tabControl.TabPages.Remove(tabOform);

            buttonOrders.Enabled = true;
            buttonGoods.Enabled = true;
            buttonProviders.Enabled = true;
            buttonSupplies.Enabled = false;
            buttonPurchases.Enabled = true;
            buttonSending.Enabled = true;

            buttonSupplies.BackColor = Color.MediumSlateBlue;
            buttonOrders.BackColor = Color.FromArgb(51, 51, 76);
            buttonProviders.BackColor = Color.FromArgb(51, 51, 76);
            buttonGoods.BackColor = Color.FromArgb(51, 51, 76);
            buttonPurchases.BackColor = Color.FromArgb(51, 51, 76);
            buttonSending.BackColor = Color.FromArgb(51, 51, 76);
        }

        private void buttonPurchases_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Add(tabPurchases);
            tabControl.TabPages.Remove(tabProducts);
            tabControl.TabPages.Remove(tabProviders);
            tabControl.TabPages.Remove(tabSupplies);
            tabControl.TabPages.Remove(tabOrders);
            tabControl.TabPages.Remove(tabSending);
            tabControl.TabPages.Remove(tabOform);

            buttonOrders.Enabled = true;
            buttonGoods.Enabled = true;
            buttonProviders.Enabled = true;
            buttonSupplies.Enabled = true;
            buttonPurchases.Enabled = false;
            buttonSending.Enabled = true;

            buttonPurchases.BackColor = Color.MediumSlateBlue;
            buttonOrders.BackColor = Color.FromArgb(51, 51, 76);
            buttonProviders.BackColor = Color.FromArgb(51, 51, 76);
            buttonSupplies.BackColor = Color.FromArgb(51, 51, 76);
            buttonGoods.BackColor = Color.FromArgb(51, 51, 76);
            buttonSending.BackColor = Color.FromArgb(51, 51, 76);
        }

        private void buttonSending_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Add(tabSending);
            tabControl.TabPages.Remove(tabProducts);
            tabControl.TabPages.Remove(tabProviders);
            tabControl.TabPages.Remove(tabSupplies);
            tabControl.TabPages.Remove(tabPurchases);
            tabControl.TabPages.Remove(tabOrders);
            tabControl.TabPages.Remove(tabOform);

            buttonOrders.Enabled = true;
            buttonGoods.Enabled = true;
            buttonProviders.Enabled = true;
            buttonSupplies.Enabled = true;
            buttonPurchases.Enabled = true;
            buttonSending.Enabled = false;

            buttonSending.BackColor = Color.MediumSlateBlue;
            buttonOrders.BackColor = Color.FromArgb(51, 51, 76);
            buttonProviders.BackColor = Color.FromArgb(51, 51, 76);
            buttonSupplies.BackColor = Color.FromArgb(51, 51, 76);
            buttonPurchases.BackColor = Color.FromArgb(51, 51, 76);
            buttonGoods.BackColor = Color.FromArgb(51, 51, 76);
        }

        public IEnumerable<ProductModel> GetProducts()
        {
            IEnumerable<ProductModel> productList = new List<ProductModel>();
            productList = repository.GetAllProducts();

            cbProducts.Items.Clear();
            foreach (var product in productList)
            {
                cbProducts.Items.Add(product.Product_id);
            }
            return productList;
        }

        public void GetProviders()
        {
            IEnumerable<ProviderModel> providerList = new List<ProviderModel>();
            providerList = repository.GetAllProviders();

            cbProviders.Items.Clear();
            foreach (var pr in providerList)
            {
                cbProviders.Items.Add(pr.Provider_id);
            }
        }


        //-----------------------------------------------//
        //-----------------------------------------------//


        private string message;
        private bool isSuccess;
        private bool isEdit;
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccess
        {
            get { return isSuccess; }
            set { isSuccess = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        //-------------------------------------------------//

        public int product_id
        {
            get { return Convert.ToInt32(cbProducts.Text); }
            set { cbProducts.Text = value.ToString(); }
        }

        public int provider_id
        {
            get { return Convert.ToInt32(cbProviders.Text); }
            set { cbProviders.Text = value.ToString(); }
        }
        public int quantity
        {
            get { return Convert.ToInt32(tbQuantity.Text); }
            set { tbQuantity.Text = value.ToString(); }
        }

        private void btnSpravka_Click(object sender, EventArgs e)
        {
            formSpravka form = new formSpravka();
            form.Show();
        }


    }
}