
namespace InfiLibProj
{
    partial class BooksForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DeleteBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.UpdateBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.AddBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.BookName = new Guna.UI2.WinForms.Guna2TextBox();
            this.BookId = new Guna.UI2.WinForms.Guna2TextBox();
            this.bookIssued = new Guna.UI2.WinForms.Guna2TextBox();
            this.Author = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DataGridView2 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.searchBtn = new Guna.UI2.WinForms.Guna2TileButton();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteBtn.CheckedState.Parent = this.DeleteBtn;
            this.DeleteBtn.CustomImages.Parent = this.DeleteBtn;
            this.DeleteBtn.FillColor = System.Drawing.Color.Black;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteBtn.HoverState.Parent = this.DeleteBtn;
            this.DeleteBtn.Location = new System.Drawing.Point(625, 107);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.ShadowDecoration.Parent = this.DeleteBtn;
            this.DeleteBtn.Size = new System.Drawing.Size(175, 55);
            this.DeleteBtn.TabIndex = 16;
            this.DeleteBtn.Text = "DELETE";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Transparent;
            this.UpdateBtn.CheckedState.Parent = this.UpdateBtn;
            this.UpdateBtn.CustomImages.Parent = this.UpdateBtn;
            this.UpdateBtn.FillColor = System.Drawing.Color.Black;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.UpdateBtn.HoverState.Parent = this.UpdateBtn;
            this.UpdateBtn.Location = new System.Drawing.Point(225, 107);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.ShadowDecoration.Parent = this.UpdateBtn;
            this.UpdateBtn.Size = new System.Drawing.Size(175, 55);
            this.UpdateBtn.TabIndex = 15;
            this.UpdateBtn.Text = "UPDATE";
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddBtn.CheckedState.Parent = this.AddBtn;
            this.AddBtn.CustomImages.Parent = this.AddBtn;
            this.AddBtn.FillColor = System.Drawing.Color.Black;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AddBtn.HoverState.Parent = this.AddBtn;
            this.AddBtn.Location = new System.Drawing.Point(31, 107);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.ShadowDecoration.Parent = this.AddBtn;
            this.AddBtn.Size = new System.Drawing.Size(175, 55);
            this.AddBtn.TabIndex = 14;
            this.AddBtn.Text = "ADD";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // BookName
            // 
            this.BookName.BorderColor = System.Drawing.Color.Black;
            this.BookName.BorderThickness = 2;
            this.BookName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BookName.DefaultText = "";
            this.BookName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BookName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.BookName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BookName.DisabledState.Parent = this.BookName;
            this.BookName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BookName.FillColor = System.Drawing.Color.WhiteSmoke;
            this.BookName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(86)))), ((int)(((byte)(205)))));
            this.BookName.FocusedState.Parent = this.BookName;
            this.BookName.FocusedState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.BookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookName.ForeColor = System.Drawing.Color.Black;
            this.BookName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BookName.HoverState.Parent = this.BookName;
            this.BookName.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BookName.Location = new System.Drawing.Point(132, 40);
            this.BookName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BookName.Name = "BookName";
            this.BookName.PasswordChar = '\0';
            this.BookName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.BookName.PlaceholderText = "Book Name";
            this.BookName.SelectedText = "";
            this.BookName.ShadowDecoration.BorderRadius = 1;
            this.BookName.ShadowDecoration.Parent = this.BookName;
            this.BookName.Size = new System.Drawing.Size(337, 40);
            this.BookName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.BookName.TabIndex = 18;
            // 
            // BookId
            // 
            this.BookId.BorderColor = System.Drawing.Color.Black;
            this.BookId.BorderThickness = 2;
            this.BookId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BookId.DefaultText = "";
            this.BookId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BookId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.BookId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BookId.DisabledState.Parent = this.BookId;
            this.BookId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BookId.FillColor = System.Drawing.Color.WhiteSmoke;
            this.BookId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(86)))), ((int)(((byte)(205)))));
            this.BookId.FocusedState.Parent = this.BookId;
            this.BookId.FocusedState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.BookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookId.ForeColor = System.Drawing.Color.Black;
            this.BookId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BookId.HoverState.Parent = this.BookId;
            this.BookId.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BookId.Location = new System.Drawing.Point(31, 40);
            this.BookId.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BookId.Name = "BookId";
            this.BookId.PasswordChar = '\0';
            this.BookId.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.BookId.PlaceholderText = "Book ID";
            this.BookId.SelectedText = "";
            this.BookId.ShadowDecoration.BorderRadius = 1;
            this.BookId.ShadowDecoration.Parent = this.BookId;
            this.BookId.Size = new System.Drawing.Size(91, 40);
            this.BookId.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.BookId.TabIndex = 19;
            // 
            // bookIssued
            // 
            this.bookIssued.BorderColor = System.Drawing.Color.Black;
            this.bookIssued.BorderThickness = 2;
            this.bookIssued.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bookIssued.DefaultText = "";
            this.bookIssued.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bookIssued.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bookIssued.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bookIssued.DisabledState.Parent = this.bookIssued;
            this.bookIssued.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bookIssued.FillColor = System.Drawing.Color.WhiteSmoke;
            this.bookIssued.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(86)))), ((int)(((byte)(205)))));
            this.bookIssued.FocusedState.Parent = this.bookIssued;
            this.bookIssued.FocusedState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.bookIssued.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIssued.ForeColor = System.Drawing.Color.Black;
            this.bookIssued.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bookIssued.HoverState.Parent = this.bookIssued;
            this.bookIssued.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bookIssued.Location = new System.Drawing.Point(704, 40);
            this.bookIssued.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bookIssued.Name = "bookIssued";
            this.bookIssued.PasswordChar = '\0';
            this.bookIssued.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.bookIssued.PlaceholderText = "Issued";
            this.bookIssued.SelectedText = "";
            this.bookIssued.ShadowDecoration.BorderRadius = 1;
            this.bookIssued.ShadowDecoration.Parent = this.bookIssued;
            this.bookIssued.Size = new System.Drawing.Size(96, 40);
            this.bookIssued.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.bookIssued.TabIndex = 21;
            // 
            // Author
            // 
            this.Author.BorderColor = System.Drawing.Color.Black;
            this.Author.BorderThickness = 2;
            this.Author.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Author.DefaultText = "";
            this.Author.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Author.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Author.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Author.DisabledState.Parent = this.Author;
            this.Author.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Author.FillColor = System.Drawing.Color.WhiteSmoke;
            this.Author.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(86)))), ((int)(((byte)(205)))));
            this.Author.FocusedState.Parent = this.Author;
            this.Author.FocusedState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author.ForeColor = System.Drawing.Color.Black;
            this.Author.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Author.HoverState.Parent = this.Author;
            this.Author.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Author.Location = new System.Drawing.Point(479, 40);
            this.Author.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Author.Name = "Author";
            this.Author.PasswordChar = '\0';
            this.Author.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.Author.PlaceholderText = "Author";
            this.Author.SelectedText = "";
            this.Author.ShadowDecoration.BorderRadius = 1;
            this.Author.ShadowDecoration.Parent = this.Author;
            this.Author.Size = new System.Drawing.Size(215, 40);
            this.Author.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Author.TabIndex = 22;
            // 
            // guna2DataGridView2
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView2.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView2.EnableHeadersVisualStyles = false;
            this.guna2DataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.Location = new System.Drawing.Point(31, 218);
            this.guna2DataGridView2.Name = "guna2DataGridView2";
            this.guna2DataGridView2.RowHeadersVisible = false;
            this.guna2DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView2.Size = new System.Drawing.Size(769, 315);
            this.guna2DataGridView2.TabIndex = 23;
            this.guna2DataGridView2.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView2.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(31, 180);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(22, 22);
            this.guna2HtmlLabel5.TabIndex = 32;
            this.guna2HtmlLabel5.Text = "ID";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(211, 180);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(95, 22);
            this.guna2HtmlLabel1.TabIndex = 33;
            this.guna2HtmlLabel1.Text = "Book Name";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(412, 180);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(57, 22);
            this.guna2HtmlLabel2.TabIndex = 34;
            this.guna2HtmlLabel2.Text = "Author";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(671, 180);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(57, 22);
            this.guna2HtmlLabel3.TabIndex = 35;
            this.guna2HtmlLabel3.Text = "Issued";
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchBtn.CheckedState.Parent = this.searchBtn;
            this.searchBtn.CustomImages.Parent = this.searchBtn;
            this.searchBtn.FillColor = System.Drawing.Color.Black;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.searchBtn.HoverState.Parent = this.searchBtn;
            this.searchBtn.Location = new System.Drawing.Point(425, 107);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.ShadowDecoration.Parent = this.searchBtn;
            this.searchBtn.Size = new System.Drawing.Size(175, 55);
            this.searchBtn.TabIndex = 36;
            this.searchBtn.Text = "SEARCH";
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(830, 570);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2DataGridView2);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.bookIssued);
            this.Controls.Add(this.BookId);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BooksForm";
            this.Text = "BooksForm";
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TileButton DeleteBtn;
        private Guna.UI2.WinForms.Guna2TileButton UpdateBtn;
        private Guna.UI2.WinForms.Guna2TileButton AddBtn;
        private Guna.UI2.WinForms.Guna2TextBox BookName;
        private Guna.UI2.WinForms.Guna2TextBox BookId;
        private Guna.UI2.WinForms.Guna2TextBox bookIssued;
        private Guna.UI2.WinForms.Guna2TextBox Author;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TileButton searchBtn;
        public Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView2;
    }
}