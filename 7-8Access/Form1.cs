using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel_ClassLibrary1;

namespace _7_8Access
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            string newSql;
            string name = textName.Text.Trim();
            string number = textNumber2.Text.Trim();
            string tel = textTel.Text.Trim();
            string clas = textClass.Text.Trim();
            var filePath = "Excel表格.xls";
                if (string.IsNullOrEmpty(name)||string.IsNullOrEmpty(number)||string.IsNullOrEmpty(tel)||string.IsNullOrEmpty(clas))
                {
                    MessageBox.Show("请输入完整的内容");
                }
                else
                {
                    if (b)
                    {
                        sql = "insert into [学生信息$](学号,姓名,班级,电话号码,状态)values({0},'{1}','{2}','{3}','{4}');";
                        string s = "正常";
                        newSql = string.Format(sql, number, name, clas, tel,s);
                    }
                    else
                    {
                        sql = "Update [学生信息$] set 姓名='{0}',班级='{1}',电话号码='{2}' where 学号={3};";
                        newSql = string.Format(sql, name, clas, tel, number);
                    }
                    Excel_ClassLibrary1.Class1.SetDAtatable(newSql,filePath);
                    button4_Click(null, null);

                }
            
            
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var filePath = "Excel表格.xls";
                //              ./Excel表格.xls
                //CREATE TABLE 学生信息([学号] INT,[姓名] VarChar,[班级] VarChar,[电话号码] VarChar,[状态] VarChar)
                string sql = "create table 学生信息([学号] int,[姓名] varchar,[班级] varchar,[电话号码] varchar,[状态] varchar)";
                Excel_ClassLibrary1.Class1.SetDAtatable(sql, filePath);
            }
            catch
            { }

        }
        DataTable dt = new DataTable();
        private void button4_Click(object sender, EventArgs e)
        {
           
            
                var filePath="Excel表格.xls";
                string sql="select 学号,姓名,班级,电话号码 from [学生信息$] where 状态='正常'";
                dt= Excel_ClassLibrary1.Class1.GetDAtatable(sql, filePath);
                dataGridView1.DataSource = dt;
            
        }
        bool b;
        private void butInset_Click(object sender, EventArgs e)
        {
            label6.Enabled = true;
            butPut.Enabled = true;
            butCel.Enabled = true;
            b = true;
            label6.Text = "插入";
        }

        private void butUp_Click(object sender, EventArgs e)
        {
            label6.Enabled = true;
            butPut.Enabled = true;
            butCel.Enabled = true;
            b = false;
            label6.Text = "修改";
        }

        private void textNumber2_TextChanged(object sender, EventArgs e)
        {
            textNumber.Text = textNumber2.Text.Trim();
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            var filePath = "Excel表格.xls";
            string sql = "Update [学生信息$] set 状态='删除' where 学号={0};";
            sql = string.Format(sql, textNumber.Text.Trim());
            Excel_ClassLibrary1.Class1.SetDAtatable(sql, filePath);
            button4_Click(null, null);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
                
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                textNumber2.Text = dt.Rows[index].ItemArray[0].ToString();
                textName.Text = dt.Rows[index].ItemArray[1].ToString();
                textClass.Text = dt.Rows[index].ItemArray[2].ToString();
                textTel.Text = dt.Rows[index].ItemArray[3].ToString();
            }
            catch
            { }
        }

        private void butCel_Click(object sender, EventArgs e)
        {
            textTel.Text = null;
            textName.Text = null;
            textNumber2.Text = null;
            textClass.Text = null;
        }

      

     
    }
}
