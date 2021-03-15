
namespace CarInventory
{
    partial class formCarInventory
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
            this.components = new System.ComponentModel.Container();
            this.labelMake = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.comboBoxMake = new System.Windows.Forms.ComboBox();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.checkBoxNew = new System.Windows.Forms.CheckBox();
            this.listViewEntries = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMake
            // 
            this.labelMake.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelMake.Location = new System.Drawing.Point(45, 20);
            this.labelMake.Name = "labelMake";
            this.labelMake.Size = new System.Drawing.Size(100, 25);
            this.labelMake.TabIndex = 0;
            this.labelMake.Text = "&Make:";
            this.labelMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelModel
            // 
            this.labelModel.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelModel.Location = new System.Drawing.Point(45, 58);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(100, 25);
            this.labelModel.TabIndex = 2;
            this.labelModel.Text = "M&odel:";
            this.labelModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelYear
            // 
            this.labelYear.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelYear.Location = new System.Drawing.Point(45, 97);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(100, 25);
            this.labelYear.TabIndex = 4;
            this.labelYear.Text = "&Year: ";
            this.labelYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPrice
            // 
            this.labelPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelPrice.Location = new System.Drawing.Point(45, 141);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(100, 25);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "&Price: ";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxMake
            // 
            this.comboBoxMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMake.FormattingEnabled = true;
            this.comboBoxMake.Items.AddRange(new object[] {
            "Volkswagen",
            "Toyota",
            "Ford",
            "Honda",
            "BMW",
            "Nissan",
            "Mazda",
            "Benz",
            "Accura",
            "Suzuki"});
            this.comboBoxMake.Location = new System.Drawing.Point(161, 17);
            this.comboBoxMake.Name = "comboBoxMake";
            this.comboBoxMake.Size = new System.Drawing.Size(151, 28);
            this.comboBoxMake.TabIndex = 1;
            this.toolTip.SetToolTip(this.comboBoxMake, "Select the make of the car.");
            // 
            // labelError
            // 
            this.labelError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelError.Location = new System.Drawing.Point(4, 429);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(445, 79);
            this.labelError.TabIndex = 10;
            this.toolTip.SetToolTip(this.labelError, "Displays all error messages");
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(364, 511);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(85, 30);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "E&xit";
            this.toolTip.SetToolTip(this.buttonExit, "Click to exit the application.");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExitClick);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(182, 511);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(85, 30);
            this.buttonEnter.TabIndex = 11;
            this.buttonEnter.Text = "&Enter";
            this.toolTip.SetToolTip(this.buttonEnter, "Click to enter the current car.");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.ButtonEnterClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(273, 511);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(85, 30);
            this.buttonReset.TabIndex = 12;
            this.buttonReset.Text = "&Reset";
            this.toolTip.SetToolTip(this.buttonReset, "Click to reset alll entry fields.");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonResetClick);
            // 
            // checkBoxNew
            // 
            this.checkBoxNew.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxNew.Location = new System.Drawing.Point(91, 184);
            this.checkBoxNew.Name = "checkBoxNew";
            this.checkBoxNew.Size = new System.Drawing.Size(91, 24);
            this.checkBoxNew.TabIndex = 8;
            this.checkBoxNew.Text = "&New:";
            this.toolTip.SetToolTip(this.checkBoxNew, "Select if the car is new.");
            this.checkBoxNew.UseVisualStyleBackColor = true;
            // 
            // listViewEntries
            // 
            this.listViewEntries.CheckBoxes = true;
            this.listViewEntries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewEntries.FullRowSelect = true;
            this.listViewEntries.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewEntries.HideSelection = false;
            this.listViewEntries.Location = new System.Drawing.Point(4, 214);
            this.listViewEntries.MultiSelect = false;
            this.listViewEntries.Name = "listViewEntries";
            this.listViewEntries.Size = new System.Drawing.Size(445, 203);
            this.listViewEntries.TabIndex = 9;
            this.toolTip.SetToolTip(this.listViewEntries, "Displays the list of all cars.");
            this.listViewEntries.UseCompatibleStateImageBehavior = false;
            this.listViewEntries.View = System.Windows.Forms.View.Details;
            this.listViewEntries.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.PreventCheck);
            this.listViewEntries.SelectedIndexChanged += new System.EventHandler(this.CarSelected);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "New";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Make";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Model";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Year";
            this.columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Price";
            this.columnHeader6.Width = 90;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(161, 56);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(151, 27);
            this.textBoxModel.TabIndex = 3;
            this.toolTip.SetToolTip(this.textBoxModel, "Enter the model of the car.");
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(161, 139);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(151, 27);
            this.textBoxPrice.TabIndex = 7;
            this.toolTip.SetToolTip(this.textBoxPrice, "Enter the price of the car.");
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Location = new System.Drawing.Point(161, 97);
            this.numericUpDownYear.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.numericUpDownYear.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.ReadOnly = true;
            this.numericUpDownYear.Size = new System.Drawing.Size(151, 27);
            this.numericUpDownYear.TabIndex = 5;
            this.toolTip.SetToolTip(this.numericUpDownYear, "Select the manufacture year of the car.");
            this.numericUpDownYear.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // formCarInventory
            // 
            this.AcceptButton = this.buttonReset;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(453, 553);
            this.Controls.Add(this.numericUpDownYear);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.listViewEntries);
            this.Controls.Add(this.checkBoxNew);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.comboBoxMake);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelMake);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formCarInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMake;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.ComboBox comboBoxMake;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.CheckBox checkBoxNew;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ListView listViewEntries;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownYear;
    }
}

