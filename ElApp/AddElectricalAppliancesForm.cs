using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElApp
{
    public partial class AddElectricalAppliancesForm : Form
    {
        SqlCommand command;
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataGridView dataGridView;
        DataSet data;
        string str;
        public AddElectricalAppliancesForm(SqlConnection connection, string str, DataGridView datagridView, DataSet data)
        {
            InitializeComponent();
            this.connection = connection;
            this.str = str;
            this.dataGridView = datagridView;
            this.data = data;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (NametextBox.Text == "")
                MessageBox.Show("Введите название продукта");
            else if (DateEntertextBox.Text == "")
                MessageBox.Show("Введите дату выпуска");
            else if (ManufacturertextBox.Text == "")
                MessageBox.Show("Введите производителя продукта");
            else if (WeighttextBox.Text == "")
                MessageBox.Show("Введите вес продукта");
            else if (DataSelltextBox.Text == "")
                MessageBox.Show("Введите дату продажи");
            else if (CountrytextBox.Text == "")
                MessageBox.Show("Введите страну продукта");
            else
            {
                command = new SqlCommand($"insert into {str} values('{NametextBox.Text}','{DateEntertextBox.Text}','{ManufacturertextBox.Text}',{PricenumericUpDown.Value},{WeighttextBox.Text},'{DataSelltextBox.Text}',{CostsnumericUpDown.Value},'{CountrytextBox.Text}',{CracknumericUpDown.Value});", connection);
                adapter = new SqlDataAdapter(command);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
                adapter.Fill(data);
                dataGridView.DataSource = data.Tables[0];
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
