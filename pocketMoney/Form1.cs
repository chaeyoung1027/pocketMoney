using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pocketMoney
{
    public partial class Form1 : Form
    {
        static private List<PMoney> money = new List<PMoney>()
        {
            new PMoney() {Name="박수영", schoolNum = "3102", pocketmoney = 100000, useMoney = 50000},
            new PMoney() {Name="김지영", schoolNum = "3101", pocketmoney = 300000, useMoney = 500000},
            new PMoney() {Name="최미영", schoolNum = "3113", pocketmoney = 200000, useMoney = 200000},
            new PMoney() {Name="김수현", schoolNum = "3201", pocketmoney = 400000, useMoney = 300000},
            new PMoney() {Name="김정현", schoolNum = "3202", pocketmoney = 350000, useMoney = 300000},
            new PMoney() {Name="이서윤", schoolNum = "3203", pocketmoney = 150000, useMoney = 100000},
            new PMoney() {Name="김서진", schoolNum = "3302", pocketmoney = 200000, useMoney = 50000},
            new PMoney() {Name="박서진", schoolNum = "3303", pocketmoney = 180000, useMoney = 150000},
            new PMoney() {Name="김서윤", schoolNum = "3301", pocketmoney = 200000, useMoney = 150000},
            new PMoney() {Name="최수영", schoolNum = "3304", pocketmoney = 300000, useMoney = 300000},
            new PMoney() {Name="곽준빈", schoolNum = "3401", pocketmoney = 350000, useMoney = 300000},
            new PMoney() {Name="권수지", schoolNum = "3402", pocketmoney = 200000, useMoney = 150000},
            new PMoney() {Name="강하늘", schoolNum = "3501", pocketmoney = 50000, useMoney = 50000},
            new PMoney() {Name="박찬호", schoolNum = "3503", pocketmoney = 100000, useMoney = 100000},
            new PMoney() {Name="김준열", schoolNum = "3602", pocketmoney = 500000, useMoney = 450000},
            new PMoney() {Name="최시준", schoolNum = "3604", pocketmoney = 150000, useMoney = 150000},
            new PMoney() {Name="양수혁", schoolNum = "3704", pocketmoney = 200000, useMoney = 200000},
            new PMoney() {Name="이미진", schoolNum = "3709", pocketmoney = 250000, useMoney = 200000},
            new PMoney() {Name="김현지", schoolNum = "3701", pocketmoney = 50000, useMoney = 30000},
            new PMoney() {Name="장준영", schoolNum = "3710", pocketmoney = 150000, useMoney = 150000},
            new PMoney() {Name="편수혁", schoolNum = "3713", pocketmoney = 300000, useMoney = 300000},
            new PMoney() {Name="박준열", schoolNum = "3805", pocketmoney = 500000, useMoney = 700000},
            new PMoney() {Name="최박김", schoolNum = "3807", pocketmoney = 400000, useMoney = 400000},
            new PMoney() {Name="박최영", schoolNum = "3806", pocketmoney = 600000, useMoney = 500000},
            new PMoney() {Name="하수혁", schoolNum = "3814", pocketmoney = 450000, useMoney = 400000},
            new PMoney() {Name="최민혁", schoolNum = "3908", pocketmoney = 200000, useMoney = 150000},
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pocketMoneyBindingSource.DataSource = money;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //학번
            pocketMoneyBindingSource.DataSource = from item in money
                                                  orderby item.schoolNum
                                                  select item;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //용돈이 20만원보다 많은 사람만
            pocketMoneyBindingSource.DataSource = from item in money
                                                  where item.pocketmoney>200000
                                                  orderby item.schoolNum
                                                  select item;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //쓴 돈이 용돈보다 많은 사람
            pocketMoneyBindingSource.DataSource = from item in money
                                                  where item.pocketmoney < item.useMoney
                                                  orderby item.schoolNum
                                                  select item;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //용돈 순으로
            pocketMoneyBindingSource.DataSource = from item in money
                                                  orderby item.schoolNum
                                                  select item.pocketmoney;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            pocketMoneyBindingSource.DataSource = money;
        }
    }
}
