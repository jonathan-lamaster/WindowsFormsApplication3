using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("C:\\HL7\\data.xml"))
            {
                DataSet ds = new DataSet();
                ds.ReadXml("C:\\HL7\\data.xml");
                foreach (DataRow item in ds.Tables["InterfaceTests"].Rows)
                {
                    int n = dataGridView.Rows.Add();
                    dataGridView.Rows[n].Cells[0].Value = item["TestName"].ToString();
                    dataGridView.Rows[n].Cells[2].Value = item["InputMessage"].ToString();
                    dataGridView.Rows[n].Cells[3].Value = item["ExpectedOutput"].ToString();
                    dataGridView.Rows[n].Cells[1].Value = item["Description"].ToString();
                }
            }

        }

        private void SaveData()
        {
           DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.TableName = "InterfaceTests";
            dt.Columns.Add("TestName");
            dt.Columns.Add("InputMessage");
            dt.Columns.Add("ExpectedOutput");
            dt.Columns.Add("Description");
            ds.Tables.Add(dt);

            foreach (DataGridViewRow r in dataGridView.Rows)
             {   DataRow row = ds.Tables["InterfaceTests"].NewRow();
                    row["TestName"] = r.Cells[0].Value.ToString();
                    row["InputMessage"] = r.Cells[2].Value.ToString();
                    row["ExpectedOutput"] = r.Cells[3].Value.ToString();
                    row["Description"] = r.Cells[1].Value.ToString();
                    ds.Tables["InterfaceTests"].Rows.Add(row);
            }

            ds.WriteXml("C:\\HL7\\data.xml");
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            int n = dataGridView.Rows.Add();
            dataGridView.Rows[n].Cells[0].Value = TestNametextBox.Text;
            dataGridView.Rows[n].Cells[1].Value = DescriptiontextBox.Text;
            dataGridView.Rows[n].Cells[2].Value = InputMessagetextBox.Text;
            dataGridView.Rows[n].Cells[3].Value = ExpectedOutputtextBox.Text;

            SaveData();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView.SelectedRows)
            {
                dataGridView.Rows.RemoveAt(item.Index);
            }
            SaveData();
        }

        private void RunTestButton_Click(object sender, EventArgs e)
        {


            foreach (DataGridViewRow item in dataGridView.Rows)
            {
                File.WriteAllText(@"C:\\HL7\\Inbox\\message.hl7", item.Cells[2].Value.ToString());
                Thread.Sleep(2000);
                try
                {
                    using (StreamReader sr = new StreamReader("C:\\HL7\\Outbox\\message.hl7"))
                    {
                        String line = sr.ReadToEnd();
                        line = line.TrimEnd('\r', '\n');
                        if (line.Equals(item.Cells["ExpectedOutput"].Value))
                        {
                            MessageBox.Show(String.Format("The {0} test passed ", item.Cells[0].Value));
                        }
                        else
                        {
                            MessageBox.Show(String.Format("The {0} test failed ", item.Cells[0].Value));
                        }
                        sr.Close();
                        File.Delete("C:\\HL7\\Outbox\\message.hl7");
                    }
                }

                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }

            }
        }

        }

    }

