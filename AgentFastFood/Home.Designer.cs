namespace AgentFastFood
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodOrderingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agentFastFoodDataSet1 = new AgentFastFood.AgentFastFoodDataSet1();
            this.foodOrderingTableAdapter = new AgentFastFood.AgentFastFoodDataSet1TableAdapters.FoodOrderingTableAdapter();
            this.txtFoodID = new System.Windows.Forms.TextBox();
            this.txtPayMed = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.dateAgent = new System.Windows.Forms.DateTimePicker();
            this.btSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodOrderingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentFastFoodDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.foodDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.paymentMethodDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.foodOrderingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(215, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(757, 471);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // foodDataGridViewTextBoxColumn
            // 
            this.foodDataGridViewTextBoxColumn.DataPropertyName = "Food";
            this.foodDataGridViewTextBoxColumn.HeaderText = "Food";
            this.foodDataGridViewTextBoxColumn.Name = "foodDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // paymentMethodDataGridViewTextBoxColumn
            // 
            this.paymentMethodDataGridViewTextBoxColumn.DataPropertyName = "PaymentMethod";
            this.paymentMethodDataGridViewTextBoxColumn.HeaderText = "PaymentMethod";
            this.paymentMethodDataGridViewTextBoxColumn.Name = "paymentMethodDataGridViewTextBoxColumn";
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // foodOrderingBindingSource
            // 
            this.foodOrderingBindingSource.DataMember = "FoodOrdering";
            this.foodOrderingBindingSource.DataSource = this.agentFastFoodDataSet1;
            // 
            // agentFastFoodDataSet1
            // 
            this.agentFastFoodDataSet1.DataSetName = "AgentFastFoodDataSet1";
            this.agentFastFoodDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // foodOrderingTableAdapter
            // 
            this.foodOrderingTableAdapter.ClearBeforeFill = true;
            // 
            // txtFoodID
            // 
            this.txtFoodID.Location = new System.Drawing.Point(15, 66);
            this.txtFoodID.Name = "txtFoodID";
            this.txtFoodID.Size = new System.Drawing.Size(100, 20);
            this.txtFoodID.TabIndex = 3;
            this.txtFoodID.TextChanged += new System.EventHandler(this.txtFoodID_TextChanged);
            // 
            // txtPayMed
            // 
            this.txtPayMed.Location = new System.Drawing.Point(15, 121);
            this.txtPayMed.Name = "txtPayMed";
            this.txtPayMed.Size = new System.Drawing.Size(100, 20);
            this.txtPayMed.TabIndex = 4;
            this.txtPayMed.TextChanged += new System.EventHandler(this.txtPayMed_TextChanged);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(12, 50);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(18, 13);
            this.lbID.TabIndex = 6;
            this.lbID.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Payment Method";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(12, 180);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(30, 13);
            this.lbDate.TabIndex = 8;
            this.lbDate.Text = "Date";
            // 
            // dateAgent
            // 
            this.dateAgent.Location = new System.Drawing.Point(9, 214);
            this.dateAgent.Name = "dateAgent";
            this.dateAgent.Size = new System.Drawing.Size(200, 20);
            this.dateAgent.TabIndex = 9;
            this.dateAgent.ValueChanged += new System.EventHandler(this.dateAgent_ValueChanged);
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(40, 279);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(75, 23);
            this.btSubmit.TabIndex = 10;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.dateAgent);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.txtPayMed);
            this.Controls.Add(this.txtFoodID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodOrderingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentFastFoodDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private AgentFastFoodDataSet1 agentFastFoodDataSet1;
        private System.Windows.Forms.BindingSource foodOrderingBindingSource;
        private AgentFastFoodDataSet1TableAdapters.FoodOrderingTableAdapter foodOrderingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtFoodID;
        private System.Windows.Forms.TextBox txtPayMed;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.DateTimePicker dateAgent;
        private System.Windows.Forms.Button btSubmit;
    }
}