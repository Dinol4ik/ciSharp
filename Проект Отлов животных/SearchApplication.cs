using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static Проект_Отлов_животных.Models;
using ClosedXML.Excel;

namespace Проект_Отлов_животных
{
    public partial class SearchApplication : Form
    {
        public SearchApplication(List<Application> application, List<Models.Locality> localitiy, string roleUser)
        {
            data = application;
            InitializeComponent();
            if (roleUser == "Куратор ВетСлужбы"
                || roleUser == "Подписант ВетСлужбы"
                || roleUser == "Куратор ОМСУ"
                || roleUser == "Подписант ОМСУ"
                || roleUser == "Подписант по отлову"
                || roleUser == "Куратор по отлову")
            {
                button2.Visible = false;
                button3.Visible = false;

            }

            localityAdress.DataSource = localitiy;
            localityAdress.DisplayMember = "Adress";
            localityAdress.ValueMember = "Id";
            dataGridView1.DataSource = data.GetRange(0, data.Count);
            label2.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
        }
        List<Application> data;

        private void button1_Click(object sender, EventArgs e)
        {
            AplicationHandler aplicationFinde = new AplicationHandler();
            var title = textBox1.Text.ToString();
            var finde = aplicationFinde.ApplicationFinde(title);
            var d = finde;
            dataGridView1.DataSource = d.GetRange(0, data.Count);
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(label2.Text);

                if (data.Find(x => x.Id == id) != null) { data.Remove(data.Find(x => x.Id == id)); }
                AplicationHandler aplicationHandler = new AplicationHandler();
                aplicationHandler.DeleteAplication(id);
                dataGridView1.DataSource = data.GetRange(0, data.Count);
                dataGridView1.Refresh();
                MessageBox.Show("Запись удалена");
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка при удалении");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Models.Locality localityID = (Models.Locality)localityAdress.SelectedItem;
                Models.Applications applications = new Models.Applications
                {
                    Id = int.Parse(label2.Text),
                    Date = dateTimePicker1.Value.ToString(),
                    Description = textBox4.Text,
                    Kategory = listBox1.SelectedItem.ToString(),
                    //Locality = localityID,
                    AnimalHabitat = textBox3.Text,
                    LocalityId = localityID.Id,
                    number = int.Parse(textBox2.Text),
                    UrgencyOfExecution = Convert.ToBoolean(checkBox1.Checked)
                };
                AplicationHandler aplicationHandler = new AplicationHandler();
                aplicationHandler.EditAplication(applications);
                MessageBox.Show("Запись успешно изменена!");
            }
            catch (Exception)
            {

                MessageBox.Show("Произошла ошибка проверьте правильность данных!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label2.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            var dat = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            var descr = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            var habit = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
            bool chek = Convert.ToBoolean(dataGridView1[5, dataGridView1.CurrentRow.Index].Value);
            var number = dataGridView1[7, dataGridView1.CurrentRow.Index].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dat);
            textBox4.Text = descr;
            textBox3.Text = habit;
            textBox2.Text = number;
            checkBox1.Checked = chek;
        }

        private void button4_Click(object sender, EventArgs e)
        {          
            var path = Path.Combine(Environment.CurrentDirectory, "Export", "data.xlsx");

            var wb = new XLWorkbook();
            var sh = wb.Worksheets.Add("test");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    sh.Cell(row.Index +1, col.Index + 1).SetValue(dataGridView1.Rows[row.Index].Cells[col.Index].Value.ToString());
                }                
            }
            /*
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    sh.Cell(i + 1, j + 1).SetValue(dataGridView1.CurrentCell.Value.ToString());
                    
                }
            }
            */
            wb.SaveAs(path);
        }
    }
}
