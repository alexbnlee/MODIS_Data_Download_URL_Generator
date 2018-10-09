using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace MODIS数据下载地址生成
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int year = DateTime.Now.Year;
        int month = DateTime.Now.Month;
        string monstr;
        string[] dataContent = {"L3m_MO_SST4_sst4_4km.nc","L3m_MO_RRS_Rrs_488_4km.nc",
                                   "L3m_MO_RRS_Rrs_531_4km.nc","L3m_MO_RRS_Rrs_547_4km.nc",
                                   "L3m_MO_RRS_Rrs_645_4km.nc","L3m_MO_RRS_Rrs_667_4km.nc",
                                   "L3m_MO_CHL_chlor_a_4km.nc","L3m_MO_PAR_par_4km.nc"};
        string[] dataSite = new string[8];
        string nasa = "http://oceandata.sci.gsfc.nasa.gov/cgi/getfile/";
        string download;

        Excel.Application ex = new Excel.Application();
        Excel.Workbook eWorkbook;
        Excel.Worksheet eWorksheet;

        private void Form1_Load(object sender, EventArgs e)
        {
            //if (month == 1)
            //{
            //    year = year - 1;
            //    month = 12;
            //}
            //else
            //{
            //    month = month - 1;
            //}

            //cb_year.Text = year.ToString();
            //cb_month.Text = month.ToString();

            richTextBox1.Font = new Font("Times New Roman", 12,richTextBox1.Font.Style);

            textBox1.Font = new System.Drawing.Font("Courier New", 20, FontStyle.Bold);

            eWorkbook = ex.Workbooks.Open(Directory.GetCurrentDirectory() + @"\config.xlsx", Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);
            eWorksheet = eWorkbook.Sheets[1];
            cb_year.Text = eWorksheet.Range["A2:A2"].Value.ToString();
            nud_year.Value = Convert.ToInt32(cb_year.Text);
            cb_month.Text = eWorksheet.Range["B2:B2"].Value.ToString();
            nud_month.Value = Convert.ToInt32(cb_month.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            download = "";
            year = Convert.ToInt32(cb_year.Text);
            month = Convert.ToInt32(cb_month.Text);

            #region monstr建立
            if (year%4 == 0)
            {
                switch (month)
                {
                    case 1:
                        monstr = year.ToString() + "001" + year.ToString() + "031";
                        break;

                    case 2:
                        monstr = year.ToString() + "032" + year.ToString() + "060";
                        break;

                    case 3:
                        monstr = year.ToString() + "061" + year.ToString() + "091";
                        break;

                    case 4:
                        monstr = year.ToString() + "092" + year.ToString() + "121";
                        break;

                    case 5:
                        monstr = year.ToString() + "122" + year.ToString() + "152";
                        break;

                    case 6:
                        monstr = year.ToString() + "153" + year.ToString() + "182";
                        break;

                    case 7:
                        monstr = year.ToString() + "183" + year.ToString() + "213";
                        break;

                    case 8:
                        monstr = year.ToString() + "214" + year.ToString() + "244";
                        break;

                    case 9:
                        monstr = year.ToString() + "245" + year.ToString() + "274";
                        break;

                    case 10:
                        monstr = year.ToString() + "275" + year.ToString() + "305";
                        break;

                    case 11:
                        monstr = year.ToString() + "306" + year.ToString() + "335";
                        break;

                    case 12:
                        monstr = year.ToString() + "336" + year.ToString() + "366";
                        break;

                }
            } 
            else
            {
                switch (month)
            {
                case 1:
                    monstr = year.ToString() + "001" + year.ToString() + "031";
                    break;

                case 2:
                    monstr = year.ToString() + "032" + year.ToString() + "059";
                    break;

                case 3:
                    monstr = year.ToString() + "060" + year.ToString() + "090";
                    break;

                case 4:
                    monstr = year.ToString() + "091" + year.ToString() + "120";
                    break;

                case 5:
                    monstr = year.ToString() + "121" + year.ToString() + "151";
                    break;

                case 6:
                    monstr = year.ToString() + "152" + year.ToString() + "181";
                    break;

                case 7:
                    monstr = year.ToString() + "182" + year.ToString() + "212";
                    break;

                case 8:
                    monstr = year.ToString() + "213" + year.ToString() + "243";
                    break;

                case 9:
                    monstr = year.ToString() + "244" + year.ToString() + "273";
                    break;

                case 10:
                    monstr = year.ToString() + "274" + year.ToString() + "304";
                    break;

                case 11:
                    monstr = year.ToString() + "305" + year.ToString() + "334";
                    break;

                case 12:
                    monstr = year.ToString() + "335" + year.ToString() + "365";
                    break;

            }
            }
            #endregion

            for (int i = 0; i < dataContent.Length; i++)
            {
                dataSite[i] = monstr + "." + dataContent[i];
            }

            for (int i = 0; i < dataContent.Length * 2; i++)
            {
                if (i < dataContent.Length)
                {
                    download = download + nasa + "T" + dataSite[i] + "\n";
                }
                else
                {
                    download = download + nasa + "A" + dataSite[i - dataContent.Length] + "\n";
                }
            }    

            richTextBox1.Text = download;

            string codeStr = "";
            codeStr = "./bnli.sh " + cb_year.Text + " " + cb_month.Text;
            textBox1.Text = codeStr;
            Clipboard.Clear();
            Clipboard.SetDataObject(codeStr + "\n");
            if (nud_month.Value == 12)
                nud_year.Value++;
            nud_month.Value++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();  //清空剪切板内容
            Clipboard.SetData(DataFormats.Text, richTextBox1.Text);    //复制内容到剪切板
            MessageBox.Show("下载地址复制成功！(*^__^*) 嘻嘻……", "信息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void nud_year_ValueChanged(object sender, EventArgs e)
        {
            cb_year.Text = nud_year.Value.ToString();
            if (nud_year.Value == 2021)
            {
                nud_year.Value = 2000;
            }
            if (nud_year.Value == 1999)
            {
                nud_year.Value = 2020;
            }

        }

        private void nud_month_ValueChanged(object sender, EventArgs e)
        {
            cb_month.Text = nud_month.Value.ToString();
            if (nud_month.Value == 13)
            {
                nud_month.Value = 1;
            }
            if (nud_month.Value == 0)
            {
                nud_month.Value = 12;
            }
        }

        private void cb_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            eWorksheet.Range["A2:A2"].Value = cb_year.Text;
            nud_year.Value = Convert.ToInt32(cb_year.Text);
        }

        private void cb_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            eWorksheet.Range["B2:B2"].Value = cb_month.Text;
            nud_month.Value = Convert.ToInt32(cb_month.Text);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            eWorkbook.Save();
            eWorkbook.Close();
            ex.Quit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetDataObject(nasa + "A" + monstr + ".L3m_MO_SST4_sst4_4km.nc\n");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetDataObject(nasa + "A" + monstr + ".L3m_MO_CHL_chlor_a_4km.nc\n");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetDataObject(nasa + "A" + monstr + ".L3m_MO_PAR_par_4km.nc\n");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetDataObject(nasa + "A" + monstr + ".L3m_MO_RRS_Rrs_488_4km.nc\n");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetDataObject(nasa + "A" + monstr + ".L3m_MO_RRS_Rrs_531_4km.nc\n");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetDataObject(nasa + "A" + monstr + ".L3m_MO_RRS_Rrs_547_4km.nc\n");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetDataObject(nasa + "A" + monstr + ".L3m_MO_RRS_Rrs_645_4km.nc\n");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetDataObject(nasa + "A" + monstr + ".L3m_MO_RRS_Rrs_667_4km.nc\n");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetDataObject(nasa + "T" + monstr + ".L3m_MO_SST4_sst4_4km.nc\n");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetDataObject(nasa + "T" + monstr + ".L3m_MO_CHL_chlor_a_4km.nc\n");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetDataObject(nasa + "T" + monstr + ".L3m_MO_PAR_par_4km.nc\n");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetDataObject(nasa + "T" + monstr + ".L3m_MO_RRS_Rrs_488_4km.nc\n");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetDataObject(nasa + "T" + monstr + ".L3m_MO_RRS_Rrs_531_4km.nc\n");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetDataObject(nasa + "T" + monstr + ".L3m_MO_RRS_Rrs_547_4km.nc\n");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetDataObject(nasa + "T" + monstr + ".L3m_MO_RRS_Rrs_645_4km.nc\n");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetDataObject(nasa + "T" + monstr + ".L3m_MO_RRS_Rrs_667_4km.nc\n");
        }
    }
}
