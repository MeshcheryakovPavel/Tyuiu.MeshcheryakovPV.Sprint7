using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MescheryakovPV.Sprint7.V6.Lib;

namespace Tyuiu.MescheryakovPV.Sprint7.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            try
            {
                ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowData()
        {
            if (DataService.DataIsValid(DataService.path))
            {
                try
                {
                    dataGridView_MPV.DataSource = DataService.GetData();
                    dataGridView_MPV.Columns[0].Width = 45;
                    dataGridView_MPV.Columns[4].Width = 60;

                    if (DataService.GetData().Rows.Count >= 1)
                    {
                        buttonDelete_MPV.Enabled = true;
                    }
                    else
                    {
                        buttonDelete_MPV.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Неподходящая таблица");
            }
        }

        private void buttonAdd_MPV_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes =
            {
                textBoxFName_MPV,
                textBoxLName_MPV,
                textBoxMName_MPV,
                textBoxAge_MPV,
                textBoxDisease_MPV,
                textBoxDoctor_MPV,
                textBoxPhoneNumber_MPV
            };
            try
            {
                string[] arr = new string[8];

                if (String.IsNullOrEmpty(textBoxFName_MPV.Text) && String.IsNullOrEmpty(textBoxLName_MPV.Text) && String.IsNullOrEmpty(textBoxAge_MPV.Text))
                {
                    MessageBox.Show("Имя/Фамилия/Возраст должны иметь значения");
                }
                else if (String.IsNullOrEmpty(textBoxFName_MPV.Text) || String.IsNullOrEmpty(textBoxLName_MPV.Text) || String.IsNullOrEmpty(textBoxAge_MPV.Text))
                {
                    MessageBox.Show("Имя/Фамилия/Возраст должны иметь значения");
                }
                else if (!IsNumber(textBoxAge_MPV) || !IsNumber(textBoxPhoneNumber_MPV))
                {
                    MessageBox.Show("Возраст и номер телефона должны быть записаны в виде цифр");
                }
                else
                {
                    int counter = 1;
                    foreach (var textBox in textBoxes)
                    {
                        arr[counter] = textBox.Text;
                        textBox.Clear();
                        counter++;
                    }

                    bool res = DataService.AddData(arr);
                    if (res == false)
                        MessageBox.Show("Не соблюдается уникальность значений!");

                    ShowData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_MPV_Click(object sender, EventArgs e)
        {
            try
            {
                string id = Convert.ToString(dataGridView_MPV.CurrentRow.Cells["id"].Value);
                DataService.DeleteData(id);
                ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_MPV_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxInfo_MPV.Text = Convert.ToString(dataGridView_MPV[e.ColumnIndex, e.RowIndex].Value);
        }

        private bool IsNumber(TextBox textbox)
        {
            Int64 n;
            if (Int64.TryParse(textbox.Text, out n))
                return true;
            else if (string.IsNullOrEmpty(textbox.Text))
                return true;


            return false;
        }

        private void buttonChangePath_MPV_Click(object sender, EventArgs e)
        {
            openFileDialog_MPV.ShowDialog();

            if (DataService.DataIsValid(openFileDialog_MPV.FileName))
            {
                DataService.path = openFileDialog_MPV.FileName;
            }
            else
            {
                MessageBox.Show("Неподходящая таблица");
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxFilter_MPV.Text) && dataGridView_MPV.Rows.Count >= 1)
            {
                try
                {
                    string word = textBoxFilter_MPV.Text;
                    int columnIndex = dataGridView_MPV.CurrentCell.ColumnIndex;
                    dataGridView_MPV.CurrentCell = null;

                    for (int i = 0; i < dataGridView_MPV.Rows.Count; i++)
                    {
                        dataGridView_MPV.Rows[i].Visible = dataGridView_MPV[columnIndex, i].Value.ToString() == word;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonReturnDefault_MPV_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void buttonChange_MPV_Click(object sender, EventArgs e)
        {
            try
            {
                TextBox[] textBoxes =
                {
                    textBoxFName_MPV,
                    textBoxLName_MPV,
                    textBoxMName_MPV,
                    textBoxAge_MPV,
                    textBoxDisease_MPV,
                    textBoxDoctor_MPV,
                    textBoxPhoneNumber_MPV
                };

                string[] textBoxesText =
                {
                    textBoxFName_MPV.Text,
                    textBoxLName_MPV.Text,
                    textBoxMName_MPV.Text,
                    textBoxAge_MPV.Text,
                    textBoxDisease_MPV.Text,
                    textBoxDoctor_MPV.Text,
                    textBoxPhoneNumber_MPV.Text
                };

                string rowId = dataGridView_MPV.CurrentRow.Cells[0].Value.ToString();

                DataService.ChangeData(rowId, textBoxesText);

                foreach (TextBox tb in textBoxes)
                {
                    tb.Clear();
                }

                ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonFrequency_MPV_Click(object sender, EventArgs e)
        {
            try
            {
                FormStatistic form = new FormStatistic();
                form.Show();
                if (dataGridView_MPV.Rows.Count >= 1)
                {
                    string columnName = dataGridView_MPV.Columns[dataGridView_MPV.CurrentCell.ColumnIndex].Name;
                    form.ShowChart(columnName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonInfo_MPV_Click(object sender, EventArgs e)
        {
            FormInfo form = new FormInfo();
            form.Show();
        }

        private void panelMenu_MPV_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxFilter_MPV_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxFilter_MPV_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxEnterData_MPV_Enter(object sender, EventArgs e)
        {

        }

        private void panelEnterData_MPV_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxPhoneNumber_MPV_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPhoneNumber_MPV_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDoctor_MPV_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDoctor_MPV_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDisease_MPV_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDisease_MPV_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAge_MPV_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelAge_MPV_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMName_MPV_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelMName_MPV_Click(object sender, EventArgs e)
        {

        }

        private void labelLName_MPV_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLName_MPV_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelFName_MPV_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFName_MPV_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_MPV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelInfo_MPV_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxInfo_MPV_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog_MPV_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void toolTip_MPV_Popup(object sender, PopupEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
