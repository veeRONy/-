using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p_ch_m_i
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSpravka = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSending = new System.Windows.Forms.Button();
            this.buttonPurchases = new System.Windows.Forms.Button();
            this.buttonSupplies = new System.Windows.Forms.Button();
            this.buttonProviders = new System.Windows.Forms.Button();
            this.buttonGoods = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.tabOform = new System.Windows.Forms.TabPage();
            this.btnCancel = new p_ch_m_i.RoundedButton();
            this.btnOform = new p_ch_m_i.RoundedButton();
            this.roundedPanel1 = new p_ch_m_i.RoundedPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbProviders = new System.Windows.Forms.ComboBox();
            this.tabSending = new System.Windows.Forms.TabPage();
            this.pnlSendings = new p_ch_m_i.RoundedPanel();
            this.dgvSendings = new System.Windows.Forms.DataGridView();
            this.tabPurchases = new System.Windows.Forms.TabPage();
            this.pnlPurchases = new p_ch_m_i.RoundedPanel();
            this.dgvPurchases = new System.Windows.Forms.DataGridView();
            this.tabSupplies = new System.Windows.Forms.TabPage();
            this.pnlSupplies = new p_ch_m_i.RoundedPanel();
            this.dgvSupplies = new System.Windows.Forms.DataGridView();
            this.tabProviders = new System.Windows.Forms.TabPage();
            this.btnDeleteProvider = new p_ch_m_i.RoundedButton();
            this.pnlProviders = new p_ch_m_i.RoundedPanel();
            this.dgvProviders = new System.Windows.Forms.DataGridView();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.btnOformZakupku = new p_ch_m_i.RoundedButton();
            this.btnDeleteProduct = new p_ch_m_i.RoundedButton();
            this.pnlProducts = new p_ch_m_i.RoundedPanel();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.tabOrders = new System.Windows.Forms.TabPage();
            this.pnlOrders = new p_ch_m_i.RoundedPanel();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.panelMenu.SuspendLayout();
            this.tabOform.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.tabSending.SuspendLayout();
            this.pnlSendings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSendings)).BeginInit();
            this.tabPurchases.SuspendLayout();
            this.pnlPurchases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchases)).BeginInit();
            this.tabSupplies.SuspendLayout();
            this.pnlSupplies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplies)).BeginInit();
            this.tabProviders.SuspendLayout();
            this.pnlProviders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviders)).BeginInit();
            this.tabProducts.SuspendLayout();
            this.pnlProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.tabOrders.SuspendLayout();
            this.pnlOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnSpravka);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.buttonSending);
            this.panelMenu.Controls.Add(this.buttonPurchases);
            this.panelMenu.Controls.Add(this.buttonSupplies);
            this.panelMenu.Controls.Add(this.buttonProviders);
            this.panelMenu.Controls.Add(this.buttonGoods);
            this.panelMenu.Controls.Add(this.buttonOrders);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(217, 642);
            this.panelMenu.TabIndex = 0;
            // 
            // btnSpravka
            // 
            this.btnSpravka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpravka.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSpravka.FlatAppearance.BorderSize = 0;
            this.btnSpravka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpravka.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSpravka.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSpravka.Location = new System.Drawing.Point(0, 546);
            this.btnSpravka.Name = "btnSpravka";
            this.btnSpravka.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSpravka.Size = new System.Drawing.Size(217, 60);
            this.btnSpravka.TabIndex = 8;
            this.btnSpravka.Text = "Справка";
            this.btnSpravka.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpravka.UseVisualStyleBackColor = true;
            this.btnSpravka.Click += new System.EventHandler(this.btnSpravka_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 453);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 93);
            this.panel1.TabIndex = 7;
            // 
            // buttonSending
            // 
            this.buttonSending.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSending.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSending.FlatAppearance.BorderSize = 0;
            this.buttonSending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSending.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSending.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSending.Location = new System.Drawing.Point(0, 393);
            this.buttonSending.Name = "buttonSending";
            this.buttonSending.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonSending.Size = new System.Drawing.Size(217, 60);
            this.buttonSending.TabIndex = 6;
            this.buttonSending.Text = "Отправки";
            this.buttonSending.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSending.UseVisualStyleBackColor = true;
            this.buttonSending.Click += new System.EventHandler(this.buttonSending_Click);
            // 
            // buttonPurchases
            // 
            this.buttonPurchases.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPurchases.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPurchases.FlatAppearance.BorderSize = 0;
            this.buttonPurchases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPurchases.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPurchases.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonPurchases.Location = new System.Drawing.Point(0, 333);
            this.buttonPurchases.Name = "buttonPurchases";
            this.buttonPurchases.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonPurchases.Size = new System.Drawing.Size(217, 60);
            this.buttonPurchases.TabIndex = 5;
            this.buttonPurchases.Text = "Закупки";
            this.buttonPurchases.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPurchases.UseVisualStyleBackColor = true;
            this.buttonPurchases.Click += new System.EventHandler(this.buttonPurchases_Click);
            // 
            // buttonSupplies
            // 
            this.buttonSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSupplies.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSupplies.FlatAppearance.BorderSize = 0;
            this.buttonSupplies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupplies.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSupplies.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSupplies.Location = new System.Drawing.Point(0, 273);
            this.buttonSupplies.Name = "buttonSupplies";
            this.buttonSupplies.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonSupplies.Size = new System.Drawing.Size(217, 60);
            this.buttonSupplies.TabIndex = 4;
            this.buttonSupplies.Text = "Поставки";
            this.buttonSupplies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSupplies.UseVisualStyleBackColor = true;
            this.buttonSupplies.Click += new System.EventHandler(this.buttonSupplies_Click);
            // 
            // buttonProviders
            // 
            this.buttonProviders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProviders.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProviders.FlatAppearance.BorderSize = 0;
            this.buttonProviders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProviders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonProviders.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonProviders.Location = new System.Drawing.Point(0, 213);
            this.buttonProviders.Name = "buttonProviders";
            this.buttonProviders.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonProviders.Size = new System.Drawing.Size(217, 60);
            this.buttonProviders.TabIndex = 3;
            this.buttonProviders.Text = "Поставщики";
            this.buttonProviders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProviders.UseVisualStyleBackColor = true;
            this.buttonProviders.Click += new System.EventHandler(this.buttonProviders_Click);
            // 
            // buttonGoods
            // 
            this.buttonGoods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGoods.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGoods.FlatAppearance.BorderSize = 0;
            this.buttonGoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoods.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGoods.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonGoods.Location = new System.Drawing.Point(0, 153);
            this.buttonGoods.Name = "buttonGoods";
            this.buttonGoods.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonGoods.Size = new System.Drawing.Size(217, 60);
            this.buttonGoods.TabIndex = 2;
            this.buttonGoods.Text = "Товары";
            this.buttonGoods.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGoods.UseVisualStyleBackColor = true;
            this.buttonGoods.Click += new System.EventHandler(this.buttonGoods_Click);
            // 
            // buttonOrders
            // 
            this.buttonOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOrders.FlatAppearance.BorderSize = 0;
            this.buttonOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOrders.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonOrders.Location = new System.Drawing.Point(0, 93);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonOrders.Size = new System.Drawing.Size(217, 60);
            this.buttonOrders.TabIndex = 1;
            this.buttonOrders.Text = "Заказы";
            this.buttonOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrders.UseVisualStyleBackColor = true;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(217, 93);
            this.panelLogo.TabIndex = 0;
            // 
            // tabOform
            // 
            this.tabOform.Controls.Add(this.btnCancel);
            this.tabOform.Controls.Add(this.btnOform);
            this.tabOform.Controls.Add(this.roundedPanel1);
            this.tabOform.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabOform.Location = new System.Drawing.Point(4, 104);
            this.tabOform.Name = "tabOform";
            this.tabOform.Size = new System.Drawing.Size(857, 534);
            this.tabOform.TabIndex = 6;
            this.tabOform.Text = "Оформление закупки";
            this.tabOform.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 20;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(522, 559);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(169, 39);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnOform
            // 
            this.btnOform.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOform.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOform.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOform.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOform.BorderRadius = 20;
            this.btnOform.BorderSize = 0;
            this.btnOform.FlatAppearance.BorderSize = 0;
            this.btnOform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOform.ForeColor = System.Drawing.Color.White;
            this.btnOform.Location = new System.Drawing.Point(292, 559);
            this.btnOform.Name = "btnOform";
            this.btnOform.Size = new System.Drawing.Size(169, 39);
            this.btnOform.TabIndex = 9;
            this.btnOform.Text = "Оформить";
            this.btnOform.TextColor = System.Drawing.Color.White;
            this.btnOform.UseVisualStyleBackColor = false;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.roundedPanel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.roundedPanel1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.roundedPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.BorderSize = 0;
            this.roundedPanel1.Controls.Add(this.label3);
            this.roundedPanel1.Controls.Add(this.tbQuantity);
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.Controls.Add(this.cbProducts);
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Controls.Add(this.cbProviders);
            this.roundedPanel1.Location = new System.Drawing.Point(191, 164);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(595, 346);
            this.roundedPanel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(56, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Количество:";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(281, 154);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(239, 27);
            this.tbQuantity.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Код поставщика:";
            // 
            // cbProducts
            // 
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(281, 74);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(239, 28);
            this.cbProducts.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(56, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Код товара:";
            // 
            // cbProviders
            // 
            this.cbProviders.FormattingEnabled = true;
            this.cbProviders.Location = new System.Drawing.Point(281, 227);
            this.cbProviders.Name = "cbProviders";
            this.cbProviders.Size = new System.Drawing.Size(239, 28);
            this.cbProviders.TabIndex = 5;
            // 
            // tabSending
            // 
            this.tabSending.Controls.Add(this.pnlSendings);
            this.tabSending.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabSending.Location = new System.Drawing.Point(4, 104);
            this.tabSending.Name = "tabSending";
            this.tabSending.Size = new System.Drawing.Size(857, 534);
            this.tabSending.TabIndex = 5;
            this.tabSending.Text = "Отправки";
            this.tabSending.UseVisualStyleBackColor = true;
            // 
            // pnlSendings
            // 
            this.pnlSendings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSendings.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnlSendings.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.pnlSendings.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pnlSendings.BorderRadius = 20;
            this.pnlSendings.BorderSize = 0;
            this.pnlSendings.Controls.Add(this.dgvSendings);
            this.pnlSendings.Location = new System.Drawing.Point(87, 51);
            this.pnlSendings.Name = "pnlSendings";
            this.pnlSendings.Size = new System.Drawing.Size(688, 405);
            this.pnlSendings.TabIndex = 4;
            // 
            // dgvSendings
            // 
            this.dgvSendings.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dgvSendings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSendings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSendings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSendings.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvSendings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSendings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSendings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(240)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(240)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSendings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSendings.ColumnHeadersHeight = 50;
            this.dgvSendings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(240)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSendings.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSendings.EnableHeadersVisualStyles = false;
            this.dgvSendings.GridColor = System.Drawing.SystemColors.Control;
            this.dgvSendings.Location = new System.Drawing.Point(0, 3);
            this.dgvSendings.MultiSelect = false;
            this.dgvSendings.Name = "dgvSendings";
            this.dgvSendings.RowHeadersWidth = 51;
            this.dgvSendings.RowTemplate.Height = 29;
            this.dgvSendings.Size = new System.Drawing.Size(688, 402);
            this.dgvSendings.TabIndex = 3;
            // 
            // tabPurchases
            // 
            this.tabPurchases.Controls.Add(this.pnlPurchases);
            this.tabPurchases.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPurchases.Location = new System.Drawing.Point(4, 104);
            this.tabPurchases.Name = "tabPurchases";
            this.tabPurchases.Size = new System.Drawing.Size(857, 534);
            this.tabPurchases.TabIndex = 4;
            this.tabPurchases.Text = "Закупки";
            this.tabPurchases.UseVisualStyleBackColor = true;
            // 
            // pnlPurchases
            // 
            this.pnlPurchases.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPurchases.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnlPurchases.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.pnlPurchases.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pnlPurchases.BorderRadius = 20;
            this.pnlPurchases.BorderSize = 0;
            this.pnlPurchases.Controls.Add(this.dgvPurchases);
            this.pnlPurchases.Location = new System.Drawing.Point(87, 51);
            this.pnlPurchases.Name = "pnlPurchases";
            this.pnlPurchases.Size = new System.Drawing.Size(678, 410);
            this.pnlPurchases.TabIndex = 4;
            // 
            // dgvPurchases
            // 
            this.dgvPurchases.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dgvPurchases.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPurchases.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPurchases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPurchases.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPurchases.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPurchases.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPurchases.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(240)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(240)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPurchases.ColumnHeadersHeight = 50;
            this.dgvPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(240)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchases.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPurchases.EnableHeadersVisualStyles = false;
            this.dgvPurchases.GridColor = System.Drawing.SystemColors.Control;
            this.dgvPurchases.Location = new System.Drawing.Point(0, 3);
            this.dgvPurchases.MultiSelect = false;
            this.dgvPurchases.Name = "dgvPurchases";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchases.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPurchases.RowHeadersWidth = 51;
            this.dgvPurchases.RowTemplate.Height = 29;
            this.dgvPurchases.Size = new System.Drawing.Size(678, 407);
            this.dgvPurchases.TabIndex = 5;
            // 
            // tabSupplies
            // 
            this.tabSupplies.Controls.Add(this.pnlSupplies);
            this.tabSupplies.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabSupplies.Location = new System.Drawing.Point(4, 104);
            this.tabSupplies.Name = "tabSupplies";
            this.tabSupplies.Size = new System.Drawing.Size(857, 534);
            this.tabSupplies.TabIndex = 3;
            this.tabSupplies.Text = "Поставки";
            this.tabSupplies.UseVisualStyleBackColor = true;
            // 
            // pnlSupplies
            // 
            this.pnlSupplies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSupplies.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnlSupplies.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.pnlSupplies.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pnlSupplies.BorderRadius = 20;
            this.pnlSupplies.BorderSize = 0;
            this.pnlSupplies.Controls.Add(this.dgvSupplies);
            this.pnlSupplies.Location = new System.Drawing.Point(87, 51);
            this.pnlSupplies.Name = "pnlSupplies";
            this.pnlSupplies.Size = new System.Drawing.Size(662, 422);
            this.pnlSupplies.TabIndex = 4;
            // 
            // dgvSupplies
            // 
            this.dgvSupplies.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dgvSupplies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSupplies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSupplies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupplies.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvSupplies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSupplies.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSupplies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(240)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(240)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSupplies.ColumnHeadersHeight = 50;
            this.dgvSupplies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(240)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSupplies.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSupplies.EnableHeadersVisualStyles = false;
            this.dgvSupplies.GridColor = System.Drawing.SystemColors.Control;
            this.dgvSupplies.Location = new System.Drawing.Point(0, 3);
            this.dgvSupplies.MultiSelect = false;
            this.dgvSupplies.Name = "dgvSupplies";
            this.dgvSupplies.RowHeadersWidth = 51;
            this.dgvSupplies.RowTemplate.Height = 29;
            this.dgvSupplies.Size = new System.Drawing.Size(662, 419);
            this.dgvSupplies.TabIndex = 3;
            // 
            // tabProviders
            // 
            this.tabProviders.Controls.Add(this.btnDeleteProvider);
            this.tabProviders.Controls.Add(this.pnlProviders);
            this.tabProviders.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabProviders.Location = new System.Drawing.Point(4, 104);
            this.tabProviders.Name = "tabProviders";
            this.tabProviders.Size = new System.Drawing.Size(857, 534);
            this.tabProviders.TabIndex = 2;
            this.tabProviders.Text = "Поставщики";
            this.tabProviders.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProvider
            // 
            this.btnDeleteProvider.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteProvider.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteProvider.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnDeleteProvider.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDeleteProvider.BorderRadius = 18;
            this.btnDeleteProvider.BorderSize = 0;
            this.btnDeleteProvider.FlatAppearance.BorderSize = 0;
            this.btnDeleteProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProvider.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProvider.Location = new System.Drawing.Point(362, 461);
            this.btnDeleteProvider.Name = "btnDeleteProvider";
            this.btnDeleteProvider.Size = new System.Drawing.Size(146, 36);
            this.btnDeleteProvider.TabIndex = 8;
            this.btnDeleteProvider.Text = "Удалить";
            this.btnDeleteProvider.TextColor = System.Drawing.Color.White;
            this.btnDeleteProvider.UseVisualStyleBackColor = false;
            // 
            // pnlProviders
            // 
            this.pnlProviders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProviders.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnlProviders.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.pnlProviders.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pnlProviders.BorderRadius = 20;
            this.pnlProviders.BorderSize = 0;
            this.pnlProviders.Controls.Add(this.dgvProviders);
            this.pnlProviders.Location = new System.Drawing.Point(87, 51);
            this.pnlProviders.Name = "pnlProviders";
            this.pnlProviders.Size = new System.Drawing.Size(687, 391);
            this.pnlProviders.TabIndex = 3;
            // 
            // dgvProviders
            // 
            this.dgvProviders.AllowUserToAddRows = false;
            this.dgvProviders.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dgvProviders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvProviders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProviders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProviders.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProviders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProviders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProviders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(240)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(240)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProviders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvProviders.ColumnHeadersHeight = 50;
            this.dgvProviders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(240)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProviders.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvProviders.EnableHeadersVisualStyles = false;
            this.dgvProviders.GridColor = System.Drawing.SystemColors.Control;
            this.dgvProviders.Location = new System.Drawing.Point(0, 3);
            this.dgvProviders.MultiSelect = false;
            this.dgvProviders.Name = "dgvProviders";
            this.dgvProviders.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProviders.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvProviders.RowHeadersWidth = 51;
            this.dgvProviders.RowTemplate.Height = 29;
            this.dgvProviders.Size = new System.Drawing.Size(687, 388);
            this.dgvProviders.TabIndex = 5;
            // 
            // tabProducts
            // 
            this.tabProducts.Controls.Add(this.btnOformZakupku);
            this.tabProducts.Controls.Add(this.btnDeleteProduct);
            this.tabProducts.Controls.Add(this.pnlProducts);
            this.tabProducts.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabProducts.Location = new System.Drawing.Point(4, 104);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducts.Size = new System.Drawing.Size(857, 534);
            this.tabProducts.TabIndex = 1;
            this.tabProducts.Text = "Товары";
            this.tabProducts.UseVisualStyleBackColor = true;
            // 
            // btnOformZakupku
            // 
            this.btnOformZakupku.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOformZakupku.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOformZakupku.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOformZakupku.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOformZakupku.BorderRadius = 18;
            this.btnOformZakupku.BorderSize = 0;
            this.btnOformZakupku.FlatAppearance.BorderSize = 0;
            this.btnOformZakupku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOformZakupku.ForeColor = System.Drawing.Color.White;
            this.btnOformZakupku.Location = new System.Drawing.Point(263, 442);
            this.btnOformZakupku.Name = "btnOformZakupku";
            this.btnOformZakupku.Size = new System.Drawing.Size(196, 36);
            this.btnOformZakupku.TabIndex = 7;
            this.btnOformZakupku.Text = "Оформить закупку";
            this.btnOformZakupku.TextColor = System.Drawing.Color.White;
            this.btnOformZakupku.UseVisualStyleBackColor = false;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteProduct.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteProduct.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnDeleteProduct.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDeleteProduct.BorderRadius = 18;
            this.btnDeleteProduct.BorderSize = 0;
            this.btnDeleteProduct.FlatAppearance.BorderSize = 0;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProduct.Location = new System.Drawing.Point(485, 442);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(146, 36);
            this.btnDeleteProduct.TabIndex = 5;
            this.btnDeleteProduct.Text = "Удалить";
            this.btnDeleteProduct.TextColor = System.Drawing.Color.White;
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            // 
            // pnlProducts
            // 
            this.pnlProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProducts.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnlProducts.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.pnlProducts.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pnlProducts.BorderRadius = 20;
            this.pnlProducts.BorderSize = 0;
            this.pnlProducts.Controls.Add(this.dgvProducts);
            this.pnlProducts.Location = new System.Drawing.Point(87, 51);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Size = new System.Drawing.Size(702, 364);
            this.pnlProducts.TabIndex = 3;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(240)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(240)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvProducts.ColumnHeadersHeight = 50;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(240)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.GridColor = System.Drawing.SystemColors.Control;
            this.dgvProducts.Location = new System.Drawing.Point(0, 3);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 29;
            this.dgvProducts.Size = new System.Drawing.Size(702, 361);
            this.dgvProducts.TabIndex = 5;
            // 
            // tabOrders
            // 
            this.tabOrders.Controls.Add(this.pnlOrders);
            this.tabOrders.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabOrders.Location = new System.Drawing.Point(4, 104);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrders.Size = new System.Drawing.Size(857, 534);
            this.tabOrders.TabIndex = 0;
            this.tabOrders.Text = "Заказы";
            this.tabOrders.UseVisualStyleBackColor = true;
            // 
            // pnlOrders
            // 
            this.pnlOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOrders.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnlOrders.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.pnlOrders.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pnlOrders.BorderRadius = 20;
            this.pnlOrders.BorderSize = 0;
            this.pnlOrders.Controls.Add(this.dgvOrders);
            this.pnlOrders.Location = new System.Drawing.Point(87, 51);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Size = new System.Drawing.Size(630, 378);
            this.pnlOrders.TabIndex = 2;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dgvOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(240)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(240)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvOrders.ColumnHeadersHeight = 50;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(240)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrders.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgvOrders.EnableHeadersVisualStyles = false;
            this.dgvOrders.GridColor = System.Drawing.SystemColors.Control;
            this.dgvOrders.Location = new System.Drawing.Point(0, 3);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 29;
            this.dgvOrders.Size = new System.Drawing.Size(630, 375);
            this.dgvOrders.TabIndex = 4;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabOrders);
            this.tabControl.Controls.Add(this.tabProducts);
            this.tabControl.Controls.Add(this.tabProviders);
            this.tabControl.Controls.Add(this.tabSupplies);
            this.tabControl.Controls.Add(this.tabPurchases);
            this.tabControl.Controls.Add(this.tabSending);
            this.tabControl.Controls.Add(this.tabOform);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl.ItemSize = new System.Drawing.Size(100, 50);
            this.tabControl.Location = new System.Drawing.Point(217, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(865, 642);
            this.tabControl.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1082, 642);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1100, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мебельный магазин";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.tabOform.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.tabSending.ResumeLayout(false);
            this.pnlSendings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSendings)).EndInit();
            this.tabPurchases.ResumeLayout(false);
            this.pnlPurchases.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchases)).EndInit();
            this.tabSupplies.ResumeLayout(false);
            this.pnlSupplies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplies)).EndInit();
            this.tabProviders.ResumeLayout(false);
            this.pnlProviders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviders)).EndInit();
            this.tabProducts.ResumeLayout(false);
            this.pnlProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.tabOrders.ResumeLayout(false);
            this.pnlOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Button buttonOrders;
        private Panel panelLogo;
        private Button buttonPurchases;
        private Button buttonSupplies;
        private Button buttonProviders;
        private Button buttonGoods;
        private Button buttonSending;
        private TabPage tabOform;
        private Label label2;
        private Label label1;
        private TabPage tabSending;
        private RoundedPanel pnlSendings;
        private DataGridView dgvSendings;
        private TabPage tabPurchases;
        private RoundedPanel pnlPurchases;
        private TabPage tabSupplies;
        private RoundedPanel pnlSupplies;
        private DataGridView dgvSupplies;
        private TabPage tabProviders;
        private RoundedButton btnDeleteProvider;
        private RoundedPanel pnlProviders;
        private TabPage tabProducts;
        private RoundedButton btnDeleteProduct;
        private RoundedPanel pnlProducts;
        private TabPage tabOrders;
        private RoundedPanel pnlOrders;
        private TabControl tabControl;
        private Label label3;
        private RoundedPanel roundedPanel1;
        private TextBox tbQuantity;
        private ComboBox cbProducts;
        private ComboBox cbProviders;
        private RoundedButton btnOform;
        private Button btnSpravka;
        private Panel panel1;
        private RoundedButton btnOformZakupku;
        private RoundedButton btnCancel;
        private DataGridView dgvOrders;
        private DataGridView dgvPurchases;
        private DataGridView dgvProviders;
        private DataGridView dgvProducts;
    }
}