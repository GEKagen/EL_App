namespace ElApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Redactbutton = new System.Windows.Forms.Button();
            this.AddEAbutton = new System.Windows.Forms.Button();
            this.OpenDBbutton = new System.Windows.Forms.Button();
            this.Findbutton = new System.Windows.Forms.Button();
            this.Diapasonbutton = new System.Windows.Forms.Button();
            this.FindcomboBox = new System.Windows.Forms.ComboBox();
            this.CountrycomboBox = new System.Windows.Forms.ComboBox();
            this.ManufacturercomboBox = new System.Windows.Forms.ComboBox();
            this.TypescomboBox = new System.Windows.Forms.ComboBox();
            this.AverageCostlabel = new System.Windows.Forms.Label();
            this.HighPricelabel = new System.Windows.Forms.Label();
            this.LowPricelabel = new System.Windows.Forms.Label();
            this.FullAveragePricelabel = new System.Windows.Forms.Label();
            this.StarttextBox = new System.Windows.Forms.TextBox();
            this.EndtextBox = new System.Windows.Forms.TextBox();
            this.CountrytextBox = new System.Windows.Forms.TextBox();
            this.DatatextBox = new System.Windows.Forms.TextBox();
            this.ManufacturertextBox = new System.Windows.Forms.TextBox();
            this.PricetextBox = new System.Windows.Forms.TextBox();
            this.RedacttextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(21, 17);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(898, 497);
            this.dataGridView.TabIndex = 0;
            // 
            // Redactbutton
            // 
            this.Redactbutton.Location = new System.Drawing.Point(1068, 24);
            this.Redactbutton.Name = "Redactbutton";
            this.Redactbutton.Size = new System.Drawing.Size(195, 63);
            this.Redactbutton.TabIndex = 1;
            this.Redactbutton.Text = "Редактировать";
            this.Redactbutton.UseVisualStyleBackColor = true;
            this.Redactbutton.Click += new System.EventHandler(this.Redactbutton_Click_1);
            // 
            // AddEAbutton
            // 
            this.AddEAbutton.Location = new System.Drawing.Point(1600, 112);
            this.AddEAbutton.Name = "AddEAbutton";
            this.AddEAbutton.Size = new System.Drawing.Size(159, 63);
            this.AddEAbutton.TabIndex = 1;
            this.AddEAbutton.Text = "Вывести";
            this.AddEAbutton.UseVisualStyleBackColor = true;
            this.AddEAbutton.Click += new System.EventHandler(this.AddEAbutton_Click_1);
            // 
            // OpenDBbutton
            // 
            this.OpenDBbutton.Location = new System.Drawing.Point(1540, 631);
            this.OpenDBbutton.Name = "OpenDBbutton";
            this.OpenDBbutton.Size = new System.Drawing.Size(219, 74);
            this.OpenDBbutton.TabIndex = 1;
            this.OpenDBbutton.Text = "Добавить новый электропирбор";
            this.OpenDBbutton.UseVisualStyleBackColor = true;
            this.OpenDBbutton.Click += new System.EventHandler(this.OpenDBbutton_Click_1);
            // 
            // Findbutton
            // 
            this.Findbutton.Location = new System.Drawing.Point(1102, 631);
            this.Findbutton.Name = "Findbutton";
            this.Findbutton.Size = new System.Drawing.Size(161, 63);
            this.Findbutton.TabIndex = 1;
            this.Findbutton.Text = "Поиск";
            this.Findbutton.UseVisualStyleBackColor = true;
            this.Findbutton.Click += new System.EventHandler(this.Findbutton_Click_1);
            // 
            // Diapasonbutton
            // 
            this.Diapasonbutton.Location = new System.Drawing.Point(1068, 500);
            this.Diapasonbutton.Name = "Diapasonbutton";
            this.Diapasonbutton.Size = new System.Drawing.Size(111, 58);
            this.Diapasonbutton.TabIndex = 1;
            this.Diapasonbutton.Text = "Ввести диапазон";
            this.Diapasonbutton.UseVisualStyleBackColor = true;
            this.Diapasonbutton.Click += new System.EventHandler(this.Diapasonbutton_Click_1);
            // 
            // FindcomboBox
            // 
            this.FindcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FindcomboBox.FormattingEnabled = true;
            this.FindcomboBox.Items.AddRange(new object[] {
            "Найти электроприборы из заданного диапазона цены",
            "Найти электроприборы заданного производителя",
            "Найти электроприборы с заданной датой выпуска",
            "Найти электроприборы с заданным производителем и интервалом веса",
            "Найти долю проданных электроприборов за заданный период",
            "Найти самый популярный вид электроприбора",
            "Найти долю электроприборов, чья стоимость ниже заданной, от заданного заказчика",
            "Найти долю электроприборов, чья стоимость ниже заданной",
            "Найти количество брака от заданной страны и заданного поставщика",
            "Найти  среднюю стоимость электроприборов, проданных за определенный интервал врем" +
                "ени",
            "Найти электроприборы, стоимостью выше средней заданного поставщика"});
            this.FindcomboBox.Location = new System.Drawing.Point(992, 212);
            this.FindcomboBox.Name = "FindcomboBox";
            this.FindcomboBox.Size = new System.Drawing.Size(767, 24);
            this.FindcomboBox.TabIndex = 2;
            this.FindcomboBox.SelectedIndexChanged += new System.EventHandler(this.FindcomboBox_SelectedIndexChanged_1);
            // 
            // CountrycomboBox
            // 
            this.CountrycomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CountrycomboBox.FormattingEnabled = true;
            this.CountrycomboBox.Location = new System.Drawing.Point(1477, 323);
            this.CountrycomboBox.Name = "CountrycomboBox";
            this.CountrycomboBox.Size = new System.Drawing.Size(262, 24);
            this.CountrycomboBox.TabIndex = 2;
            // 
            // ManufacturercomboBox
            // 
            this.ManufacturercomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ManufacturercomboBox.FormattingEnabled = true;
            this.ManufacturercomboBox.Location = new System.Drawing.Point(1480, 518);
            this.ManufacturercomboBox.Name = "ManufacturercomboBox";
            this.ManufacturercomboBox.Size = new System.Drawing.Size(259, 24);
            this.ManufacturercomboBox.TabIndex = 2;
            this.ManufacturercomboBox.SelectedIndexChanged += new System.EventHandler(this.ManufacturercomboBox_SelectedIndexChanged_1);
            // 
            // TypescomboBox
            // 
            this.TypescomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypescomboBox.FormattingEnabled = true;
            this.TypescomboBox.Items.AddRange(new object[] {
            "Kettle",
            "Iron",
            "Fridge",
            "Printer",
            "TV",
            "Microwave",
            "Laptop",
            "Vacuum_cleaner",
            "Coffee_machine",
            "Double_boiler"});
            this.TypescomboBox.Location = new System.Drawing.Point(1508, 43);
            this.TypescomboBox.Name = "TypescomboBox";
            this.TypescomboBox.Size = new System.Drawing.Size(251, 24);
            this.TypescomboBox.TabIndex = 2;
            this.TypescomboBox.SelectedIndexChanged += new System.EventHandler(this.TypescomboBox_SelectedIndexChanged_1);
            // 
            // AverageCostlabel
            // 
            this.AverageCostlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AverageCostlabel.Location = new System.Drawing.Point(21, 676);
            this.AverageCostlabel.Name = "AverageCostlabel";
            this.AverageCostlabel.Size = new System.Drawing.Size(125, 29);
            this.AverageCostlabel.TabIndex = 3;
            // 
            // HighPricelabel
            // 
            this.HighPricelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HighPricelabel.Location = new System.Drawing.Point(224, 676);
            this.HighPricelabel.Name = "HighPricelabel";
            this.HighPricelabel.Size = new System.Drawing.Size(125, 29);
            this.HighPricelabel.TabIndex = 3;
            // 
            // LowPricelabel
            // 
            this.LowPricelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LowPricelabel.Location = new System.Drawing.Point(561, 676);
            this.LowPricelabel.Name = "LowPricelabel";
            this.LowPricelabel.Size = new System.Drawing.Size(125, 29);
            this.LowPricelabel.TabIndex = 3;
            // 
            // FullAveragePricelabel
            // 
            this.FullAveragePricelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FullAveragePricelabel.Location = new System.Drawing.Point(825, 676);
            this.FullAveragePricelabel.Name = "FullAveragePricelabel";
            this.FullAveragePricelabel.Size = new System.Drawing.Size(125, 29);
            this.FullAveragePricelabel.TabIndex = 3;
            // 
            // StarttextBox
            // 
            this.StarttextBox.Location = new System.Drawing.Point(992, 360);
            this.StarttextBox.Name = "StarttextBox";
            this.StarttextBox.Size = new System.Drawing.Size(262, 22);
            this.StarttextBox.TabIndex = 4;
            // 
            // EndtextBox
            // 
            this.EndtextBox.Location = new System.Drawing.Point(992, 441);
            this.EndtextBox.Name = "EndtextBox";
            this.EndtextBox.Size = new System.Drawing.Size(262, 22);
            this.EndtextBox.TabIndex = 4;
            // 
            // CountrytextBox
            // 
            this.CountrytextBox.Location = new System.Drawing.Point(1477, 285);
            this.CountrytextBox.Name = "CountrytextBox";
            this.CountrytextBox.Size = new System.Drawing.Size(262, 22);
            this.CountrytextBox.TabIndex = 4;
            // 
            // DatatextBox
            // 
            this.DatatextBox.Location = new System.Drawing.Point(1477, 400);
            this.DatatextBox.Name = "DatatextBox";
            this.DatatextBox.Size = new System.Drawing.Size(262, 22);
            this.DatatextBox.TabIndex = 4;
            // 
            // ManufacturertextBox
            // 
            this.ManufacturertextBox.Location = new System.Drawing.Point(1480, 475);
            this.ManufacturertextBox.Name = "ManufacturertextBox";
            this.ManufacturertextBox.Size = new System.Drawing.Size(262, 22);
            this.ManufacturertextBox.TabIndex = 4;
            // 
            // PricetextBox
            // 
            this.PricetextBox.Location = new System.Drawing.Point(1480, 580);
            this.PricetextBox.Name = "PricetextBox";
            this.PricetextBox.Size = new System.Drawing.Size(262, 22);
            this.PricetextBox.TabIndex = 4;
            // 
            // RedacttextBox
            // 
            this.RedacttextBox.Location = new System.Drawing.Point(988, 112);
            this.RedacttextBox.Name = "RedacttextBox";
            this.RedacttextBox.Size = new System.Drawing.Size(348, 22);
            this.RedacttextBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1577, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Типы электроприборов";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 654);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Средняя стоимость";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 654);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(255, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Самый дорогой вид электроприборов";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(499, 654);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(259, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Самый дешёвый вид электроприборов";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(799, 654);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Общая средняя стоимость";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1491, 561);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Стоимость";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1477, 441);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "Производитель";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1477, 366);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "Дата (ГГГГ-ММ-ДД)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1347, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 16);
            this.label13.TabIndex = 5;
            this.label13.Text = "Найти";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(998, 323);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 16);
            this.label14.TabIndex = 5;
            this.label14.Text = "Начало диапазона";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1099, 288);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 16);
            this.label15.TabIndex = 5;
            this.label15.Text = "Диапазон";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(998, 400);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 16);
            this.label16.TabIndex = 5;
            this.label16.Text = "Конец диапазона";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1477, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Страна";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1771, 725);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RedacttextBox);
            this.Controls.Add(this.PricetextBox);
            this.Controls.Add(this.ManufacturertextBox);
            this.Controls.Add(this.DatatextBox);
            this.Controls.Add(this.CountrytextBox);
            this.Controls.Add(this.EndtextBox);
            this.Controls.Add(this.StarttextBox);
            this.Controls.Add(this.FullAveragePricelabel);
            this.Controls.Add(this.LowPricelabel);
            this.Controls.Add(this.HighPricelabel);
            this.Controls.Add(this.AverageCostlabel);
            this.Controls.Add(this.TypescomboBox);
            this.Controls.Add(this.ManufacturercomboBox);
            this.Controls.Add(this.CountrycomboBox);
            this.Controls.Add(this.FindcomboBox);
            this.Controls.Add(this.Diapasonbutton);
            this.Controls.Add(this.Findbutton);
            this.Controls.Add(this.OpenDBbutton);
            this.Controls.Add(this.AddEAbutton);
            this.Controls.Add(this.Redactbutton);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Redactbutton;
        private System.Windows.Forms.Button AddEAbutton;
        private System.Windows.Forms.Button OpenDBbutton;
        private System.Windows.Forms.Button Findbutton;
        private System.Windows.Forms.Button Diapasonbutton;
        private System.Windows.Forms.ComboBox FindcomboBox;
        private System.Windows.Forms.ComboBox CountrycomboBox;
        private System.Windows.Forms.ComboBox ManufacturercomboBox;
        private System.Windows.Forms.ComboBox TypescomboBox;
        private System.Windows.Forms.Label AverageCostlabel;
        private System.Windows.Forms.Label HighPricelabel;
        private System.Windows.Forms.Label LowPricelabel;
        private System.Windows.Forms.Label FullAveragePricelabel;
        private System.Windows.Forms.TextBox StarttextBox;
        private System.Windows.Forms.TextBox EndtextBox;
        private System.Windows.Forms.TextBox CountrytextBox;
        private System.Windows.Forms.TextBox DatatextBox;
        private System.Windows.Forms.TextBox ManufacturertextBox;
        private System.Windows.Forms.TextBox PricetextBox;
        private System.Windows.Forms.TextBox RedacttextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
    }
}

