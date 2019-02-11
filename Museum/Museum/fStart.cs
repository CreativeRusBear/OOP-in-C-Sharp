using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Museum
{
    public partial class fStart : Form
    {
        int i = 0;
        Museum museum;
        List<Museum> someMuseum = new List<Museum>();
        List<int> price = new List<int>();
        class Museum
        {
            public string name, address, time;
            public int price;

            public void Input(TextBox name, TextBox address, TextBox time, TextBox price)
            {
                this.name = name.Text;
                this.address = address.Text;
                this.time = time.Text;
                this.price = Convert.ToInt32(price.Text);
            }

            public string Output()
            {
                return ("Музей:" + this.name + " ул." + this.address + " Время: " + this.time + ". Цена за билет: " + Convert.ToString(this.price) + Environment.NewLine);

            }
        }

        public fStart()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void inputBtn_Click(object sender, EventArgs e)
        {
            museum = new Museum();
            museum.Input(tbName, tbAddress, tbTime, tbMoney);
            someMuseum.Add(museum);
            price.Add(Convert.ToInt32(tbMoney.Text));
            i++;
            tbName.Text = "";
            tbAddress.Text = "";
            tbTime.Text = "";
            tbMoney.Text = "";
        }

        private void outputBtn_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < i; j++)
            {
                lbOutput.Items.Add(someMuseum[j].Output() + "\n");
            }
        }

        private void outputMinBtn_Click(object sender, EventArgs e)
        {
            int answer=0;
            for (int j = 0; j < i-1; j++)
            {
                if (price[j]<price[j+1])
                {
                    answer = j;
                    price[j + 1] = price[j];
                }
                else
                {
                    answer = j+1;
                }
            }
            lMinOutput.Text = Convert.ToString(someMuseum[answer].Output());
        }
    }
}
