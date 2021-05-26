
namespace demo
{
    partial class fSize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSize));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbSearch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pValues = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFrom = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTo = new Guna.UI2.WinForms.Guna2TextBox();
            this.From = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtHeight = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSize = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtWidth = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.dgvSize = new System.Windows.Forms.DataGridView();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorSize = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pValues.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSize)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 415);
            this.panel1.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnAdd);
            this.panel6.Controls.Add(this.btnDelete);
            this.panel6.Controls.Add(this.btnUpdate);
            this.panel6.Location = new System.Drawing.Point(7, 141);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(320, 79);
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
            this.btnAdd.Location = new System.Drawing.Point(6, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(97, 36);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(109, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(97, 36);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(212, 16);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(97, 36);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbSearch);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.pValues);
            this.panel3.Location = new System.Drawing.Point(7, 236);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 176);
            this.panel3.TabIndex = 4;
            // 
            // cbSearch
            // 
            this.cbSearch.BackColor = System.Drawing.Color.Transparent;
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
            this.cbSearch.Location = new System.Drawing.Point(15, 4);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.ShadowDecoration.Parent = this.cbSearch;
            this.cbSearch.Size = new System.Drawing.Size(127, 36);
            this.cbSearch.TabIndex = 38;
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 9;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(195)))), ((int)(((byte)(228)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Location = new System.Drawing.Point(82, 127);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(146, 36);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.txtSearch.Location = new System.Drawing.Point(148, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(161, 36);
            this.txtSearch.TabIndex = 37;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // pValues
            // 
            this.pValues.Controls.Add(this.label11);
            this.pValues.Controls.Add(this.txtFrom);
            this.pValues.Controls.Add(this.txtTo);
            this.pValues.Controls.Add(this.From);
            this.pValues.Location = new System.Drawing.Point(15, 66);
            this.pValues.Name = "pValues";
            this.pValues.Size = new System.Drawing.Size(302, 35);
            this.pValues.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(142, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Đến:";
            // 
            // txtFrom
            // 
            this.txtFrom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtFrom.BorderRadius = 10;
            this.txtFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFrom.DefaultText = "";
            this.txtFrom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFrom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFrom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFrom.DisabledState.Parent = this.txtFrom;
            this.txtFrom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFrom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFrom.FocusedState.Parent = this.txtFrom;
            this.txtFrom.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrom.ForeColor = System.Drawing.Color.Black;
            this.txtFrom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFrom.HoverState.Parent = this.txtFrom;
            this.txtFrom.Location = new System.Drawing.Point(28, 5);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.PasswordChar = '\0';
            this.txtFrom.PlaceholderText = "";
            this.txtFrom.SelectedText = "";
            this.txtFrom.ShadowDecoration.Parent = this.txtFrom;
            this.txtFrom.Size = new System.Drawing.Size(108, 26);
            this.txtFrom.TabIndex = 12;
            // 
            // txtTo
            // 
            this.txtTo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtTo.BorderRadius = 10;
            this.txtTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTo.DefaultText = "";
            this.txtTo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTo.DisabledState.Parent = this.txtTo;
            this.txtTo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTo.FocusedState.Parent = this.txtTo;
            this.txtTo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.ForeColor = System.Drawing.Color.Black;
            this.txtTo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTo.HoverState.Parent = this.txtTo;
            this.txtTo.Location = new System.Drawing.Point(174, 5);
            this.txtTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTo.Name = "txtTo";
            this.txtTo.PasswordChar = '\0';
            this.txtTo.PlaceholderText = "";
            this.txtTo.SelectedText = "";
            this.txtTo.ShadowDecoration.Parent = this.txtTo;
            this.txtTo.Size = new System.Drawing.Size(108, 26);
            this.txtTo.TabIndex = 12;
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.Location = new System.Drawing.Point(3, 7);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(23, 13);
            this.From.TabIndex = 0;
            this.From.Text = "Từ:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtHeight);
            this.panel5.Controls.Add(this.txtSize);
            this.panel5.Controls.Add(this.txtWidth);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(324, 132);
            this.panel5.TabIndex = 1;
            // 
            // txtHeight
            // 
            this.txtHeight.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtHeight.BorderRadius = 10;
            this.txtHeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHeight.DefaultText = "";
            this.txtHeight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHeight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHeight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHeight.DisabledState.Parent = this.txtHeight;
            this.txtHeight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHeight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHeight.FocusedState.Parent = this.txtHeight;
            this.txtHeight.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.ForeColor = System.Drawing.Color.Black;
            this.txtHeight.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHeight.HoverState.Parent = this.txtHeight;
            this.txtHeight.Location = new System.Drawing.Point(161, 85);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.PasswordChar = '\0';
            this.txtHeight.PlaceholderText = "";
            this.txtHeight.SelectedText = "";
            this.txtHeight.ShadowDecoration.Parent = this.txtHeight;
            this.txtHeight.Size = new System.Drawing.Size(144, 27);
            this.txtHeight.TabIndex = 12;
            this.txtHeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            // 
            // txtSize
            // 
            this.txtSize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtSize.BorderRadius = 10;
            this.txtSize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSize.DefaultText = "";
            this.txtSize.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSize.DisabledState.Parent = this.txtSize;
            this.txtSize.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSize.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSize.FocusedState.Parent = this.txtSize;
            this.txtSize.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.ForeColor = System.Drawing.Color.Black;
            this.txtSize.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSize.HoverState.Parent = this.txtSize;
            this.txtSize.Location = new System.Drawing.Point(161, 16);
            this.txtSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSize.Name = "txtSize";
            this.txtSize.PasswordChar = '\0';
            this.txtSize.PlaceholderText = "";
            this.txtSize.SelectedText = "";
            this.txtSize.ShadowDecoration.Parent = this.txtSize;
            this.txtSize.Size = new System.Drawing.Size(144, 27);
            this.txtSize.TabIndex = 1;
            this.txtSize.TextChanged += new System.EventHandler(this.txtSize_TextChanged);
            this.txtSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSize_KeyPress);
            // 
            // txtWidth
            // 
            this.txtWidth.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtWidth.BorderRadius = 10;
            this.txtWidth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWidth.DefaultText = "";
            this.txtWidth.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtWidth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtWidth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWidth.DisabledState.Parent = this.txtWidth;
            this.txtWidth.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWidth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWidth.FocusedState.Parent = this.txtWidth;
            this.txtWidth.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidth.ForeColor = System.Drawing.Color.Black;
            this.txtWidth.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWidth.HoverState.Parent = this.txtWidth;
            this.txtWidth.Location = new System.Drawing.Point(161, 50);
            this.txtWidth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.PasswordChar = '\0';
            this.txtWidth.PlaceholderText = "";
            this.txtWidth.SelectedText = "";
            this.txtWidth.ShadowDecoration.Parent = this.txtWidth;
            this.txtWidth.Size = new System.Drawing.Size(144, 27);
            this.txtWidth.TabIndex = 12;
            this.txtWidth.TextChanged += new System.EventHandler(this.txtWidth_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(19, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Chiều Rộng:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(19, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chiều Dài:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kích Thước:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.dgvSize);
            this.groupBox1.Location = new System.Drawing.Point(345, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 415);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Kích Thước";
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
            this.btnExit.Location = new System.Drawing.Point(283, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(45, 37);
            this.btnExit.TabIndex = 12;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvSize
            // 
            this.dgvSize.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSize.BackgroundColor = System.Drawing.Color.White;
            this.dgvSize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSize.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Size,
            this.Column1,
            this.Column2});
            this.dgvSize.Location = new System.Drawing.Point(6, 43);
            this.dgvSize.Name = "dgvSize";
            this.dgvSize.ReadOnly = true;
            this.dgvSize.RowHeadersVisible = false;
            this.dgvSize.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSize.Size = new System.Drawing.Size(322, 372);
            this.dgvSize.TabIndex = 0;
            this.dgvSize.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSize_CellClick);
            // 
            // Size
            // 
            this.Size.DataPropertyName = "IDSize";
            this.Size.HeaderText = "Kích Thước";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Width";
            this.Column1.HeaderText = "Chiều Dài";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Height";
            this.Column2.HeaderText = "Chiều Rộng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // errorSize
            // 
            this.errorSize.ContainerControl = this;
            // 
            // fSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 433);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fSize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fSize";
            this.Load += new System.EventHandler(this.fSize_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pValues.ResumeLayout(false);
            this.pValues.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pValues;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtFrom;
        private Guna.UI2.WinForms.Guna2TextBox txtTo;
        private Guna.UI2.WinForms.Guna2TextBox txtHeight;
        private Guna.UI2.WinForms.Guna2TextBox txtWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSize;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ErrorProvider errorSize;
        private Guna.UI2.WinForms.Guna2ComboBox cbSearch;
    }
}