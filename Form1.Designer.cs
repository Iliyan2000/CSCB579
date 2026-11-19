namespace PizzariaKasa
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblPizza = new System.Windows.Forms.Label();
            this.cmbPizza = new System.Windows.Forms.ComboBox();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbFamily = new System.Windows.Forms.RadioButton();
            this.grpExtras = new System.Windows.Forms.GroupBox();
            this.chkCheese = new System.Windows.Forms.CheckBox();
            this.chkBacon = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSummary = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblList = new System.Windows.Forms.Label();
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.grpSize.SuspendLayout();
            this.grpExtras.SuspendLayout();
            this.SuspendLayout();
            //
            // lblPizza
            //
            this.lblPizza.AutoSize = true;
            this.lblPizza.Location = new System.Drawing.Point(20, 20);
            this.lblPizza.Name = "lblPizza";
            this.lblPizza.Size = new System.Drawing.Size(70, 15);
            this.lblPizza.Text = "Вид пица:";
            //
            // cmbPizza
            //
            this.cmbPizza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPizza.Location = new System.Drawing.Point(20, 40);
            this.cmbPizza.Name = "cmbPizza";
            this.cmbPizza.Size = new System.Drawing.Size(240, 23);
            this.cmbPizza.TabIndex = 0;
            //
            // grpSize
            //
            this.grpSize.Controls.Add(this.rbSmall);
            this.grpSize.Controls.Add(this.rbMedium);
            this.grpSize.Controls.Add(this.rbFamily);
            this.grpSize.Location = new System.Drawing.Point(20, 80);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(240, 120);
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Размер";
            //
            // rbSmall
            //
            this.rbSmall.AutoSize = true;
            this.rbSmall.Checked = true;
            this.rbSmall.Location = new System.Drawing.Point(15, 25);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(180, 19);
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Малка (базова цена)";
            //
            // rbMedium
            //
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(15, 55);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(180, 19);
            this.rbMedium.Text = "Средна (+25%)";
            //
            // rbFamily
            //
            this.rbFamily.AutoSize = true;
            this.rbFamily.Location = new System.Drawing.Point(15, 85);
            this.rbFamily.Name = "rbFamily";
            this.rbFamily.Size = new System.Drawing.Size(180, 19);
            this.rbFamily.Text = "Семейна (+50%)";
            //
            // grpExtras
            //
            this.grpExtras.Controls.Add(this.chkCheese);
            this.grpExtras.Controls.Add(this.chkBacon);
            this.grpExtras.Controls.Add(this.chkMushrooms);
            this.grpExtras.Controls.Add(this.chkOlives);
            this.grpExtras.Location = new System.Drawing.Point(20, 210);
            this.grpExtras.Name = "grpExtras";
            this.grpExtras.Size = new System.Drawing.Size(240, 150);
            this.grpExtras.TabStop = false;
            this.grpExtras.Text = "Добавки (всяка +1.50 лв.)";
            //
            // chkCheese
            //
            this.chkCheese.AutoSize = true;
            this.chkCheese.Location = new System.Drawing.Point(15, 25);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(130, 19);
            this.chkCheese.Text = "Двоен кашкавал";
            //
            // chkBacon
            //
            this.chkBacon.AutoSize = true;
            this.chkBacon.Location = new System.Drawing.Point(15, 55);
            this.chkBacon.Name = "chkBacon";
            this.chkBacon.Size = new System.Drawing.Size(130, 19);
            this.chkBacon.Text = "Бекон";
            //
            // chkMushrooms
            //
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(15, 85);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(130, 19);
            this.chkMushrooms.Text = "Гъби";
            //
            // chkOlives
            //
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(15, 115);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(130, 19);
            this.chkOlives.Text = "Маслини";
            //
            // lblQuantity
            //
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(20, 375);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(120, 15);
            this.lblQuantity.Text = "Брой пици:";
            //
            // txtQuantity
            //
            this.txtQuantity.Location = new System.Drawing.Point(20, 395);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(240, 23);
            this.txtQuantity.TabIndex = 1;
            //
            // btnAdd
            //
            this.btnAdd.Location = new System.Drawing.Point(20, 435);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(240, 35);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добави към сметката";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            //
            // btnSummary
            //
            this.btnSummary.Location = new System.Drawing.Point(300, 435);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(240, 35);
            this.btnSummary.TabIndex = 3;
            this.btnSummary.Text = "Приключи сметка / Обобщение";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            //
            // btnClear
            //
            this.btnClear.Location = new System.Drawing.Point(560, 435);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 35);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Нова сметка";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            //
            // lblList
            //
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(300, 20);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(120, 15);
            this.lblList.Text = "Позиции в сметката:";
            //
            // lstOrders
            //
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.ItemHeight = 15;
            this.lstOrders.Location = new System.Drawing.Point(300, 40);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(380, 379);
            this.lstOrders.HorizontalScrollbar = true;
            this.lstOrders.TabIndex = 5;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 491);
            this.Controls.Add(this.lblPizza);
            this.Controls.Add(this.cmbPizza);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.grpExtras);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.lstOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Каса за поръчки в пицария – [Име], ф.н. [Фак. номер]";
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.grpExtras.ResumeLayout(false);
            this.grpExtras.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblPizza;
        private System.Windows.Forms.ComboBox cmbPizza;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbFamily;
        private System.Windows.Forms.GroupBox grpExtras;
        private System.Windows.Forms.CheckBox chkCheese;
        private System.Windows.Forms.CheckBox chkBacon;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.ListBox lstOrders;
    }
}
