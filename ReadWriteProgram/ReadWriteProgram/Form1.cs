using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadWriteProgram
{
    public partial class fMain : Form
    {
        string writePath = @"output.txt";
        int i = 0; int j = 0;
        Colledge coledj;
        List<Colledge> someColledge = new List<Colledge>();
        class Colledge
        {
            public string surname, name, patronymic;
            public  int group;

            public void Input(TextBox tSurname, TextBox tName, TextBox tPatronymic, TextBox tGroup)
            {
                this.surname = tSurname.Text;
                this.name = tName.Text;
                this.group = Convert.ToInt32(tGroup.Text);
                this.patronymic = tPatronymic.Text;
            }

            public string Output()
            {
                return ("Студент:" + this.surname + " " + this.name + " "+this.patronymic+". Группа №" + Convert.ToString(this.group) + Environment.NewLine);

            }
        }

        public fMain()
        {
            InitializeComponent();
        }

        private void InputBtn_Click(object sender, EventArgs e)
        {
            coledj = new Colledge();
            coledj.Input(tbSurname, tbName, tbPatronymic, tbGroup);
            someColledge.Add(coledj);
            i++;
            tbName.Text = "";
            tbSurname.Text = "";
            tbPatronymic.Text = "";
            tbGroup.Text = "";
        }

        private void OutputBtn_Click(object sender, EventArgs e)
        {
            for (j = 0; j < i; j++)
            {
                lbOutput.Items.Add(someColledge[j].Output() + "\n");
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void WriteIntoFileBtn_Click(object sender, EventArgs e)
        {
           // string writePath = @"output.txt";
            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
            {
                for (j = 0; j < i; j++)
                {
                    sw.Write(lbOutput.Items[j]);
                }
            }

        }

        private void ReadFromFile_Click(object sender, EventArgs e)
        {
            using(StreamReader sr= new StreamReader(writePath, System.Text.Encoding.Default))
            {

                textBox1.Text=sr.ReadToEnd();
            }
        }
    }
}
