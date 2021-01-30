using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class PasswordGeneratorForm : Form
    {

        public PasswordGeneratorForm()
        {
            InitializeComponent();
        }


        
        //Password作成ボタン
        private void button1_Click(object sender, EventArgs e)
        {

            int wordCount = GetWordCount();
            List<int> useTypesList = GetUseWordType();
            PasswordGenerator passwordGenerator = new PasswordGenerator();
            textBox1.Text = passwordGenerator.CreatePassword(wordCount , useTypesList);

        }

        private List<int> GetUseWordType()
        {
            List<int> useTypesList = new List<int>();

            foreach (CheckBox ck1 in groupBox2.Controls)
            {
                if (ck1.Checked)
                {
                    useTypesList.Add(int.Parse((string)ck1.Tag)  );
                }
            }
            return useTypesList;
        }

        private int GetWordCount()
        {
            var RadioGroup = groupBox1.Controls.OfType<RadioButton>()
                          .SingleOrDefault(rb => rb.Checked == true);
            return RadioGroup == null ? 0 : int.Parse((string)RadioGroup.Tag);
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
