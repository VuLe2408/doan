
namespace demo
{
    partial class fColor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fColor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtIDColor = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtColorName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSearch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.IDProductDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvColor = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.errorColor = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorColor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(3, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 268);
            this.panel1.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnDelete);
            this.panel6.Controls.Add(this.btnAdd);
            this.panel6.Location = new System.Drawing.Point(0, 121);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(221, 142);
            this.panel6.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 15;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(122, 53);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(92, 31);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 15;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(12, 53);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(92, 31);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtIDColor);
            this.panel5.Controls.Add(this.txtColorName);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(3, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(218, 110);
            this.panel5.TabIndex = 1;
            // 
            // txtIDColor
            // 
            this.txtIDColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtIDColor.BorderRadius = 10;
            this.txtIDColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDColor.DefaultText = "";
            this.txtIDColor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDColor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDColor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDColor.DisabledState.Parent = this.txtIDColor;
            this.txtIDColor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDColor.Enabled = false;
            this.txtIDColor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDColor.FocusedState.Parent = this.txtIDColor;
            this.txtIDColor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDColor.ForeColor = System.Drawing.Color.Black;
            this.txtIDColor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDColor.HoverState.Parent = this.txtIDColor;
            this.txtIDColor.Location = new System.Drawing.Point(80, 17);
            this.txtIDColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDColor.Name = "txtIDColor";
            this.txtIDColor.PasswordChar = '\0';
            this.txtIDColor.PlaceholderText = "";
            this.txtIDColor.SelectedText = "";
            this.txtIDColor.ShadowDecoration.Parent = this.txtIDColor;
            this.txtIDColor.Size = new System.Drawing.Size(131, 27);
            this.txtIDColor.TabIndex = 13;
            this.txtIDColor.TextChanged += new System.EventHandler(this.txtIDColor_TextChanged);
            this.txtIDColor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDColor_KeyPress);
            // 
            // txtColorName
            // 
            this.txtColorName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtColorName.BorderRadius = 10;
            this.txtColorName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtColorName.DefaultText = "";
            this.txtColorName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtColorName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtColorName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtColorName.DisabledState.Parent = this.txtColorName;
            this.txtColorName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtColorName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtColorName.FocusedState.Parent = this.txtColorName;
            this.txtColorName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColorName.ForeColor = System.Drawing.Color.Black;
            this.txtColorName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtColorName.HoverState.Parent = this.txtColorName;
            this.txtColorName.Location = new System.Drawing.Point(80, 68);
            this.txtColorName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtColorName.Name = "txtColorName";
            this.txtColorName.PasswordChar = '\0';
            this.txtColorName.PlaceholderText = "";
            this.txtColorName.SelectedText = "";
            this.txtColorName.ShadowDecoration.Parent = this.txtColorName;
            this.txtColorName.Size = new System.Drawing.Size(131, 27);
            this.txtColorName.TabIndex = 13;
            this.txtColorName.TextChanged += new System.EventHandler(this.txtIDColor_TextChanged);
            this.txtColorName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtColorName_KeyUp);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(14, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Màu Sắc:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(14, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Màu:";
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
            this.cbSearch.Location = new System.Drawing.Point(6, 19);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.ShadowDecoration.Parent = this.cbSearch;
            this.cbSearch.Size = new System.Drawing.Size(122, 36);
            this.cbSearch.TabIndex = 39;
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
            this.txtSearch.Location = new System.Drawing.Point(134, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(141, 33);
            this.txtSearch.TabIndex = 38;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // IDProductDetail
            // 
            this.IDProductDetail.DataPropertyName = "IDProductDetail";
            this.IDProductDetail.HeaderText = "Mã Màu";
            this.IDProductDetail.Name = "IDProductDetail";
            this.IDProductDetail.ReadOnly = true;
            this.IDProductDetail.Width = 160;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSearch);
            this.groupBox1.Controls.Add(this.dgvColor);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Location = new System.Drawing.Point(230, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 324);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Màu";
            // 
            // dgvColor
            // 
            this.dgvColor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvColor.BackgroundColor = System.Drawing.Color.White;
            this.dgvColor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvColor.Location = new System.Drawing.Point(6, 69);
            this.dgvColor.Name = "dgvColor";
            this.dgvColor.ReadOnly = true;
            this.dgvColor.RowHeadersVisible = false;
            this.dgvColor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColor.Size = new System.Drawing.Size(330, 253);
            this.dgvColor.TabIndex = 0;
            this.dgvColor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvColor_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IDColor";
            this.Column1.HeaderText = "Mã Màu";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ColorName";
            this.Column2.HeaderText = "Tên Màu";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
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
            this.btnExit.Location = new System.Drawing.Point(295, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(45, 37);
            this.btnExit.TabIndex = 11;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // errorColor
            // 
            this.errorColor.ContainerControl = this;
            // 
            // fColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 333);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fColor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fColor";
            this.Load += new System.EventHandler(this.fColor_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProductDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2TextBox txtIDColor;
        private Guna.UI2.WinForms.Guna2TextBox txtColorName;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ErrorProvider errorColor;
        private Guna.UI2.WinForms.Guna2ComboBox cbSearch;
    }
}