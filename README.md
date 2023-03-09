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
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS; initial Catalog = Electrical_appliances;Integrated Security = true;");
        AddElectricalAppliancesForm addElectricalAppliancesForm;
        SqlDataAdapter adapter;
        DataSet data = new DataSet();
        SqlCommand command;
        List<float> list = new List<float>();
        List<float> list2 = new List<float>();
        string nm;
        public Form1()
        {
            InitializeComponent();
            TypescomboBox.SelectedIndex = 0;
            CountrycomboBox.Enabled = false;
            DatatextBox.Enabled = false;
            ManufacturertextBox.Enabled = false;
            PricetextBox.Enabled = false;
            Redactbutton.Enabled = false;
            StarttextBox.Enabled = false;
            EndtextBox.Enabled = false;
            Diapasonbutton.Enabled = false;
            Findbutton.Enabled = false; ;
            ManufacturercomboBox.Enabled = false;
            CountrytextBox.Enabled = false;
        }
        public void Updating()
        {
            if (dataGridView.SelectedCells.Count > 0)
                Redactbutton.Enabled = true;
            command = new SqlCommand($"select sum(Cost) from {TypescomboBox.SelectedItem};", connection);
            connection.Open();
            float t = float.Parse(command.ExecuteScalar().ToString());
            connection.Close();
            command = new SqlCommand($"select count(*) from {TypescomboBox.SelectedItem};", connection);
            connection.Open();
            float k = float.Parse(command.ExecuteScalar().ToString());
            connection.Close();
            AverageCostlabel.Text = (t / k).ToString();
            float sum = 0;
            float sumv = 0;
            string[] words = { "Kettle", "Vacuum_cleaner", "Fridge", "Printer", "Iron", "TV", "Microwave", "Laptop", "Coffee_machine", "Double_boiler" };
            for (int i = 0; i < 10; i++)
            {
                command = new SqlCommand($"select sum(Cost) from {words[i]};", connection);
                connection.Open();
                float p = float.Parse(command.ExecuteScalar().ToString());
                sum += p;
                connection.Close();
                list.Add(p);
            }
            for (int i = 0; i < 10; i++)
            {
                command = new SqlCommand($"select count(*) from {words[i]};", connection);
                connection.Open();
                float v = float.Parse(command.ExecuteScalar().ToString());
                connection.Close();
                sumv += v;
            }
            int j = list.IndexOf(list.Max());
            HighPricelabel.Text = words[j];
            j = list.IndexOf(list.Min());
            LowPricelabel.Text = words[j];
            FullAveragePricelabel.Text = (sum / sumv).ToString();
            for (int i = 0; i < dataGridView.RowCount - 1; i++)
            {
                if (!(ManufacturercomboBox.Items.Contains(dataGridView[2, i].Value.ToString())))
                    ManufacturercomboBox.Items.Add(dataGridView[2, i].Value.ToString());
            }
            for (int i = 0; i < dataGridView.RowCount - 1; i++)
            {
                if (!(CountrycomboBox.Items.Contains(dataGridView[7, i].Value.ToString())))
                    CountrycomboBox.Items.Add(dataGridView[7, i].Value.ToString());
            }
            for (int i = 0; i < 10; i++)
            {
                command = new SqlCommand($"select sum(NumSale) from {words[i]};", connection);
                connection.Open();
                float y = float.Parse(command.ExecuteScalar().ToString());
                connection.Close();
                list2.Add(y);
            }
            int h = list2.IndexOf(list2.Max());
            nm = words[h];
        }

        public void PowerUp()
        {
            CountrycomboBox.Enabled = false;
            DatatextBox.Enabled = false;
            ManufacturertextBox.Enabled = false;
            PricetextBox.Enabled = false;
            Redactbutton.Enabled = false;
            StarttextBox.Enabled = false;
            EndtextBox.Enabled = false;
            Diapasonbutton.Enabled = false;
            ManufacturercomboBox.Enabled = false;
            Findbutton.Enabled = false;
            CountrytextBox.Enabled = false;
            dataGridView.Update();
        }
        public void UniversalData(SqlCommand coMmand)
        {
            if (data.Tables.Count > 0) data.Tables[0].Rows.Clear();
            adapter = new SqlDataAdapter(coMmand);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            adapter.Fill(data);
            dataGridView.DataSource = data.Tables[0];
            Updating();
            dataGridView.Update();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TypescomboBox.SelectedIndex = 0;
            CountrycomboBox.Enabled = false;
            DatatextBox.Enabled = false;
            ManufacturertextBox.Enabled = false;
            PricetextBox.Enabled = false;
            Redactbutton.Enabled = false;
            StarttextBox.Enabled = false;
            EndtextBox.Enabled = false;
            Diapasonbutton.Enabled = false;
            ManufacturercomboBox.Enabled = false;
            Findbutton.Enabled = false;
            CountrytextBox.Enabled = false;
            dataGridView.Update();
        }
        private void AddEAbutton_Click_1(object sender, EventArgs e)
        {
            command = new SqlCommand($"select * from {TypescomboBox.SelectedItem};", connection);
            UniversalData(command);
        }

        private void OpenDBbutton_Click_1(object sender, EventArgs e)
        {
            addElectricalAppliancesForm = new AddElectricalAppliancesForm(connection, TypescomboBox.SelectedItem.ToString(), dataGridView, data);
            addElectricalAppliancesForm.ShowDialog();
        }

        private void Redactbutton_Click_1(object sender, EventArgs e)
        {
            string x = "";
            try
            {
                x = float.Parse(RedacttextBox.Text).ToString();
            }
            catch (Exception ex)
            {
                x = $"'{RedacttextBox.Text}'";
            }

            command = new SqlCommand($"Update {TypescomboBox.SelectedItem} set {dataGridView.Columns[dataGridView.CurrentCell.ColumnIndex].Name} = {x} where Name = '{dataGridView[0, dataGridView.CurrentCell.RowIndex].Value}';", connection);
            adapter = new SqlDataAdapter(command);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            adapter.Fill(data);
            dataGridView.DataSource = data.Tables[0];
            dataGridView.Update();
            command = new SqlCommand($"select * from {TypescomboBox.SelectedItem};", connection);
            UniversalData(command);
        }

        private void Findbutton_Click_1(object sender, EventArgs e)
        {
            if (DatatextBox.Enabled)
            {
                command = new SqlCommand($"select * from {TypescomboBox.SelectedItem} where DataRelease = '{DatatextBox.Text}';", connection);
                UniversalData(command);
            }
            else if (ManufacturercomboBox.Enabled & PricetextBox.Enabled)
            {
                command = new SqlCommand($"select count(*) from {TypescomboBox.SelectedItem} where Provider = '{ManufacturercomboBox.SelectedItem}' and Cost < {PricetextBox.Text};", connection);
                connection.Open();
                float asc = float.Parse(command.ExecuteScalar().ToString());
                connection.Close();
                command = new SqlCommand($"select count(*) from {TypescomboBox.SelectedItem} where Provider = '{ManufacturercomboBox.SelectedItem}';", connection);
                connection.Open();
                float zx = float.Parse(command.ExecuteScalar().ToString());
                connection.Close();
                MessageBox.Show($"Доля товаров, дешевле {PricetextBox.Text} от {TypescomboBox.SelectedItem} - {(asc /  zx) * 100}%");
            }
            else if (PricetextBox.Enabled)
            {
                float sumbn = 0;
                float sumlk = 0;
                string[] words = { "Kettle", "Vacuum_cleaner", "Fridge", "Printer", "Iron", "TV", "Microwave", "Laptop", "Coffee_machine", "Double_boiler" };
                for (int i = 0; i < 10; i++)
                {
                    command = new SqlCommand($"select count(*) from {words[i]} where Cost < {PricetextBox.Text};", connection);
                    connection.Open();
                    float aqwe = float.Parse(command.ExecuteScalar().ToString());
                    connection.Close();
                    sumbn += aqwe;
                    command = new SqlCommand($"select count(*) from {TypescomboBox.SelectedItem};", connection);
                    connection.Open();
                    float bgc = float.Parse(command.ExecuteScalar().ToString());
                    connection.Close();
                    sumlk+=bgc;
                }
                MessageBox.Show($"Доля товаров, дешевле {PricetextBox.Text} - {(sumbn/sumlk) * 100}%");
            }
            else if (CountrycomboBox.Enabled & ManufacturercomboBox.Enabled)
            {
                var pa = ManufacturercomboBox.SelectedItem;
                if (pa == null)
                    pa = ManufacturertextBox.Text;
                else
                    pa = pa.ToString();
                var pc = CountrycomboBox.SelectedItem;
                if (pc == null)
                    pc = CountrytextBox.Text;
                else
                    pc = pc.ToString();
                command = new SqlCommand($"select Sum(Defect) from {TypescomboBox.SelectedItem} where Provider = '{pa}' and Country = '{pc}';", connection);
                connection.Open();
                float cd = 0;
                try
                {
                    cd = float.Parse(command.ExecuteScalar().ToString());
                    MessageBox.Show($"Количество брака из {pc} от {pa} - {cd}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Количество брака из {pc} от {pa} - {cd}. Возможно {pa} нету в {pc}");
                }
                connection.Close();

            }
        }

        private void Diapasonbutton_Click_1(object sender, EventArgs e)
        {
            if (FindcomboBox.SelectedIndex == 0)
                command = new SqlCommand($"select * from {TypescomboBox.SelectedItem} where Cost>={StarttextBox.Text} and Cost<={EndtextBox.Text};", connection);
            else if (FindcomboBox.SelectedIndex == 3)
                command = new SqlCommand($"select * from {TypescomboBox.SelectedItem} where ((Weight>={StarttextBox.Text} and Weight<={EndtextBox.Text}) and Provider ='{ManufacturercomboBox.SelectedItem}');", connection);
            else if (FindcomboBox.SelectedIndex == 4)
            {
                command = new SqlCommand($"select sum(NumSale) from {TypescomboBox.SelectedItem};", connection);
                connection.Open();
                float sumN = float.Parse(command.ExecuteScalar().ToString());
                connection.Close();
                command = new SqlCommand($"select sum(NumSale) from {TypescomboBox.SelectedItem} where DataSale>='{StarttextBox.Text}' and DataSale<='{EndtextBox.Text}';", connection);
                connection.Open();
                float ans = float.Parse(command.ExecuteScalar().ToString());
                connection.Close();
                MessageBox.Show($"Доля проданных товаров за заданных период - {(ans / sumN) * 100}%");
                command = new SqlCommand($"select * from {TypescomboBox.SelectedItem};", connection);
            }
            else if (FindcomboBox.SelectedIndex == 9)
            {
                float ser = 0;
                float sur = 0;
                for (int i = 0; i < 10; i++)
                {
                    command = new SqlCommand($"select sum(Cost) from {TypescomboBox.SelectedItem} where DataSale>='{StarttextBox.Text}' and DataSale<='{EndtextBox.Text}';", connection);
                    connection.Open();
                    float kl = float.Parse(command.ExecuteScalar().ToString());
                    ser += kl;
                    connection.Close();
                }
                for (int i = 0; i < 10; i++)
                {
                    command = new SqlCommand($"select count(*) from {TypescomboBox.SelectedItem} where DataSale>='{StarttextBox.Text}' and DataSale<='{EndtextBox.Text}';", connection);
                    connection.Open();
                    float ui = float.Parse(command.ExecuteScalar().ToString());
                    connection.Close();
                    sur += ui;
                }
                MessageBox.Show($"Средняя стоимость за заданных период - {ser / sur}");
                command = new SqlCommand($"select * from {TypescomboBox.SelectedItem};", connection);
            }
            UniversalData(command);
        }

        private void ManufacturercomboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (FindcomboBox.SelectedIndex == 1)
            {
                command = new SqlCommand($"select * from {TypescomboBox.SelectedItem} where Provider = '{ManufacturercomboBox.SelectedItem}';", connection);
                UniversalData(command);
            }
            else if (FindcomboBox.SelectedIndex == 10)
            {
                command = new SqlCommand($"select sum(Cost) from {TypescomboBox.SelectedItem} where Provider ='{ManufacturercomboBox.SelectedItem}';", connection);
                connection.Open();
                float hj = float.Parse(command.ExecuteScalar().ToString());
                connection.Close();
                command = new SqlCommand($"select count(*) from {TypescomboBox.SelectedItem} where Provider ='{ManufacturercomboBox.SelectedItem}';", connection);
                connection.Open();
                float we = float.Parse(command.ExecuteScalar().ToString());
                connection.Close();
                command = new SqlCommand($"select * from {TypescomboBox.SelectedItem} where Cost > {(int)(hj / we)};", connection);
                UniversalData(command);
            }
        }

        private void TypescomboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ManufacturercomboBox.Items.Clear();
            CountrycomboBox.Items.Clear();
        }

        private void FindcomboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (FindcomboBox.SelectedIndex)
            {
                case 0:
                    PowerUp();
                    StarttextBox.Enabled = true;
                    EndtextBox.Enabled = true;
                    Diapasonbutton.Enabled = true;
                    break;
                case 1:
                    PowerUp();
                    ManufacturercomboBox.Enabled = true;
                    break;
                case 2:
                    PowerUp();
                    DatatextBox.Enabled = true;
                    Findbutton.Enabled = true;
                    break;
                case 3:
                    PowerUp();
                    StarttextBox.Enabled = true;
                    EndtextBox.Enabled = true;
                    Diapasonbutton.Enabled = true;
                    ManufacturercomboBox.Enabled = true;
                    break;
                case 4:
                    PowerUp();
                    StarttextBox.Enabled = true;
                    EndtextBox.Enabled = true;
                    Diapasonbutton.Enabled = true;
                    break;
                case 5:
                    PowerUp();
                    MessageBox.Show($"Самый популярный тип элктроприборов - {nm}");
                    break;
                case 6:
                    PowerUp();
                    ManufacturercomboBox.Enabled = true;
                    PricetextBox.Enabled = true;
                    Findbutton.Enabled = true;
                    break;
                case 7:
                    PowerUp();
                    Findbutton.Enabled = true;
                    PricetextBox.Enabled = true;
                    break;
                case 8:
                    PowerUp();
                    CountrycomboBox.Enabled = true;
                    CountrytextBox.Enabled = true;
                    Findbutton.Enabled = true;
                    ManufacturertextBox.Enabled = true;
                    ManufacturercomboBox.Enabled = true;
                    break;
                case 9:
                    PowerUp();
                    StarttextBox.Enabled = true;
                    EndtextBox.Enabled = true;
                    Diapasonbutton.Enabled = true;
                    break;
                case 10:
                    PowerUp();
                    ManufacturercomboBox.Enabled = true;
                    break;
            }
        }
    }
}
