
namespace demo
{
    partial class fProductType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fProductType));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtProductTypeName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDProductType = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbSearch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvProductType = new System.Windows.Forms.DataGridView();
            this.IDProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProductType = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProductType)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Location = new System.Drawing.Point(-3, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 314);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtProductTypeName);
            this.panel5.Controls.Add(this.txtIDProductType);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(4, 48);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(240, 110);
            this.panel5.TabIndex = 1;
            // 
            // txtProductTypeName
            // 
            this.txtProductTypeName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtProductTypeName.BorderRadius = 10;
            this.txtProductTypeName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductTypeName.DefaultText = "";
            this.txtProductTypeName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductTypeName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductTypeName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductTypeName.DisabledState.Parent = this.txtProductTypeName;
            this.txtProductTypeName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductTypeName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductTypeName.FocusedState.Parent = this.txtProductTypeName;
            this.txtProductTypeName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductTypeName.ForeColor = System.Drawing.Color.Black;
            this.txtProductTypeName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductTypeName.HoverState.Parent = this.txtProductTypeName;
            this.txtProductTypeName.Location = new System.Drawing.Point(87, 66);
            this.txtProductTypeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductTypeName.Name = "txtProductTypeName";
            this.txtProductTypeName.PasswordChar = '\0';
            this.txtProductTypeName.PlaceholderText = "";
            this.txtProductTypeName.SelectedText = "";
            this.txtProductTypeName.ShadowDecoration.Parent = this.txtProductTypeName;
            this.txtProductTypeName.Size = new System.Drawing.Size(135, 27);
            this.txtProductTypeName.TabIndex = 14;
            this.txtProductTypeName.TextChanged += new System.EventHandler(this.txtProductTypeName_TextChanged);
            // 
            // txtIDProductType
            // 
            this.txtIDProductType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtIDProductType.BorderRadius = 10;
            this.txtIDProductType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDProductType.DefaultText = "";
            this.txtIDProductType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDProductType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDProductType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDProductType.DisabledState.Parent = this.txtIDProductType;
            this.txtIDProductType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDProductType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDProductType.FocusedState.Parent = this.txtIDProductType;
            this.txtIDProductType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDProductType.ForeColor = System.Drawing.Color.Black;
            this.txtIDProductType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDProductType.HoverState.Parent = this.txtIDProductType;
            this.txtIDProductType.Location = new System.Drawing.Point(87, 18);
            this.txtIDProductType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDProductType.Name = "txtIDProductType";
            this.txtIDProductType.PasswordChar = '\0';
            this.txtIDProductType.PlaceholderText = "";
            this.txtIDProductType.SelectedText = "";
            this.txtIDProductType.ShadowDecoration.Parent = this.txtIDProductType;
            this.txtIDProductType.Size = new System.Drawing.Size(135, 27);
            this.txtIDProductType.TabIndex = 14;
            this.txtIDProductType.TextChanged += new System.EventHandler(this.txtProductTypeName_TextChanged);
            this.txtIDProductType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDProductType_KeyPress);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Loại Sản Phẩm:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(11, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Loại Sản Phẩm:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnAdd);
            this.panel6.Controls.Add(this.btnDelete);
            this.panel6.Controls.Add(this.btnUpdate);
            this.panel6.Location = new System.Drawing.Point(4, 164);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(223, 134);
            this.panel6.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 9;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(195)))), ((int)(((byte)(228)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(12, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(97, 36);
            this.btnAdd.TabIndex = 41;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 9;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(195)))), ((int)(((byte)(228)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(125, 22);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(97, 36);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 9;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(195)))), ((int)(((byte)(228)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(66, 72);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(97, 36);
            this.btnUpdate.TabIndex = 43;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.IconRight = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconRight")));
            this.txtSearch.Location = new System.Drawing.Point(176, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(155, 36);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // cbSearch
            // 
            this.cbSearch.BackColor = System.Drawing.Color.Transparent;
            this.cbSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cbSearch.BorderRadius = 9;
            this.cbSearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSearch.FocusedState.Parent = this.cbSearch;
            this.cbSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSearch.HoverState.Parent = this.cbSearch;
            this.cbSearch.ItemHeight = 30;
            this.cbSearch.ItemsAppearance.Parent = this.cbSearch;
            this.cbSearch.Location = new System.Drawing.Point(0, 19);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.ShadowDecoration.Parent = this.cbSearch;
            this.cbSearch.Size = new System.Drawing.Size(170, 36);
            this.cbSearch.TabIndex = 40;
            // 
            // dgvProductType
            // 
            this.dgvProductType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductType.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProductType,
            this.ProductTypeName});
            this.dgvProductType.Location = new System.Drawing.Point(6, 79);
            this.dgvProductType.Name = "dgvProductType";
            this.dgvProductType.ReadOnly = true;
            this.dgvProductType.RowHeadersVisible = false;
            this.dgvProductType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductType.Size = new System.Drawing.Size(403, 247);
            this.dgvProductType.TabIndex = 0;
            this.dgvProductType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductType_CellClick);
            // 
            // IDProductType
            // 
            this.IDProductType.DataPropertyName = "IDProductType";
            this.IDProductType.HeaderText = "Mã Loại Sản Phẩm";
            this.IDProductType.Name = "IDProductType";
            this.IDProductType.ReadOnly = true;
            // 
            // ProductTypeName
            // 
            this.ProductTypeName.DataPropertyName = "ProductTypeName";
            this.ProductTypeName.HeaderText = "Tên Loại Sản Phẩm";
            this.ProductTypeName.Name = "ProductTypeName";
            this.ProductTypeName.ReadOnly = true;
            // 
            // errorProductType
            // 
            this.errorProductType.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.dgvProductType);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.cbSearch);
            this.groupBox1.Location = new System.Drawing.Point(241, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 315);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Loại Sản Phẩm";
            // 
            // btnExit
            // 
            this.btnExit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(54)))), ((int)(((byte)(128)))));
            this.btnExit.BorderRadius = 9;
            this.btnExit.BorderThickness = 3;
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.SystemColors.Control;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.HoverState.BorderColor = System.Drawing.SystemColors.Control;
            this.btnExit.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(364, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(45, 37);
            this.btnExit.TabIndex = 11;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // fProductType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 333);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fProductType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fProductType";
            this.Load += new System.EventHandler(this.fEditProductType_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProductType)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvProductType;
        private System.Windows.Forms.ErrorProvider errorProductType;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProductType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductTypeName;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtIDProductType;
        private Guna.UI2.WinForms.Guna2TextBox txtProductTypeName;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
    }
}