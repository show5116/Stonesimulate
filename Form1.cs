using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stone
{
    public partial class Form1 : Form
    {
        public class global // 전역변수
        {
            public static int N_peon = 0;
            public static int N_silling = 0;
            public static int N_gold = 0;
            public static int percent = 75;
            public static int cnt1 = 0;
            public static int cnt2 = 0;
            public static int cnt3 = 0;
            public static int gakS1 = 0;
            public static int gakS2 = 0;
            public static int gakS3 = 0;
        }
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 2;
            GoldIn.Text = "0";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = 0;
            global.cnt1 = 0;
            global.cnt2 = 0;
            global.cnt3 = 0;
            global.gakS1 = 0;
            global.gakS2 = 0;
            global.gakS3 = 0;
            global.percent = 75;
            percent.Text = "75%";
            gak1T.Text = "0";
            gak2T.Text = "0";
            gak3T.Text = "0";
            gak1_1.BackColor = Color.Transparent;
            gak1_2.BackColor = Color.Transparent;
            gak1_3.BackColor = Color.Transparent;
            gak1_4.BackColor = Color.Transparent;
            gak1_5.BackColor = Color.Transparent;
            gak1_6.BackColor = Color.Transparent;
            gak1_7.BackColor = Color.Transparent;
            gak1_8.BackColor = Color.Transparent;
            gak1_9.BackColor = Color.Transparent;
            gak2_10.BackColor = Color.Transparent;
            gak2_1.BackColor = Color.Transparent;
            gak2_2.BackColor = Color.Transparent;
            gak2_3.BackColor = Color.Transparent;
            gak2_4.BackColor = Color.Transparent;
            gak2_5.BackColor = Color.Transparent;
            gak2_6.BackColor = Color.Transparent;
            gak2_7.BackColor = Color.Transparent;
            gak2_8.BackColor = Color.Transparent;
            gak2_9.BackColor = Color.Transparent;
            gak2_10.BackColor = Color.Transparent;
            gak3_1.BackColor = Color.Transparent;
            gak3_2.BackColor = Color.Transparent;
            gak3_3.BackColor = Color.Transparent;
            gak3_4.BackColor = Color.Transparent;
            gak3_5.BackColor = Color.Transparent;
            gak3_6.BackColor = Color.Transparent;
            gak3_7.BackColor = Color.Transparent;
            gak3_8.BackColor = Color.Transparent;
            gak3_9.BackColor = Color.Transparent;
            gak3_10.BackColor = Color.Transparent;

            if (GoldIn.Text != "")
            {
                n = Convert.ToInt32(GoldIn.Text);
            }

            if (comboBox1.SelectedIndex == 0)         // 영웅돌
            {
                gak1_9.Hide();
                gak1_10.Hide();
                gak2_9.Hide();
                gak2_10.Hide();
                gak3_9.Hide();
                gak3_10.Hide();
                peon.Text = "5";
                silling.Text = "1160";
                global.N_peon += 5;
                global.N_gold += n;
                UseP.Text = Convert.ToString(global.N_peon);
                UseG.Text = Convert.ToString(global.N_gold);
            }
            else if (comboBox1.SelectedIndex == 1) // 전설돌
            {
                gak1_9.Show();
                gak1_10.Hide();
                gak2_9.Show();
                gak2_10.Hide();
                gak3_9.Show();
                gak3_10.Hide();
                peon.Text = "7";
                silling.Text = "1395";
                global.N_peon += 7;
                global.N_gold += n;
                UseP.Text = Convert.ToString(global.N_peon);
                UseG.Text = Convert.ToString(global.N_gold);
            }
            else if (comboBox1.SelectedIndex == 2) // 유물돌
            {
                gak1_9.Show();
                gak1_10.Show();
                gak2_9.Show();
                gak2_10.Show();
                gak3_9.Show();
                gak3_10.Show();
                peon.Text = "9";
                silling.Text = "1680";
                global.N_peon += 9;
                global.N_gold += n;
                UseP.Text = Convert.ToString(global.N_peon);
                UseG.Text = Convert.ToString(global.N_gold);
            }
        }

        private void button1_Click(object sender, EventArgs e) // 각인1
        {
            global.cnt1++;
            Random rand = new Random();
            int ran = rand.Next(0, 100);
            int Suc;

            if (comboBox1.SelectedIndex == 0)       // 영웅돌
            {
                if (global.cnt1 <= 8)
                {
                    global.N_silling += 1160;
                    UseS.Text = Convert.ToString(global.N_silling);
                    if (ran > global.percent) // 실패
                    {
                        if (global.percent != 75) global.percent += 10;
                        percent.Text = Convert.ToString(global.percent) + "%";
                        Suc = 0;
                    }
                    else // 성공
                    {
                        if (global.percent != 25) global.percent -= 10;
                        percent.Text = Convert.ToString(global.percent) + "%";
                        global.gakS1++;
                        gak1T.Text = "+" + Convert.ToString(global.gakS1);
                        Suc = 1;
                    }
                    switch (global.cnt1)
                    {
                        case 1:
                            gak1_1.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak1_1.Checked = true;
                            break;
                        case 2:
                            gak1_2.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak1_2.Checked = true;
                            break;
                        case 3:
                            gak1_3.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak1_3.Checked = true;
                            break;
                        case 4:
                            gak1_4.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak1_4.Checked = true;
                            break;
                        case 5:
                            gak1_5.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak1_5.Checked = true;
                            break;
                        case 6:
                            gak1_6.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak1_6.Checked = true;
                            break;
                        case 7:
                            gak1_7.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak1_7.Checked = true;
                            break;
                        case 8:
                            gak1_8.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak1_8.Checked = true;
                            break;
                    }
                }

            }
            else if (comboBox1.SelectedIndex == 1) // 전설돌
            {
                if (global.cnt1 <= 9)
                {
                    global.N_silling += 1395;
                    UseS.Text = Convert.ToString(global.N_silling);
                    if (ran > global.percent) // 실패
                    {
                        if (global.percent != 75) global.percent += 10;
                        percent.Text = Convert.ToString(global.percent) + "%";
                        Suc = 0;
                    }
                    else // 성공
                    {
                        if (global.percent != 25) global.percent -= 10;
                        percent.Text = Convert.ToString(global.percent) + "%";
                        global.gakS1++;
                        gak1T.Text = "+" + Convert.ToString(global.gakS1);
                        Suc = 1;
                    }
                    switch (global.cnt1)
                    {
                        case 1:
                            gak1_1.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak1_1.Checked = true;
                            break;
                        case 2:
                            gak1_2.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak1_2.Checked = true;
                            break;
                        case 3:
                            gak1_3.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak1_3.Checked = true;
                            break;
                        case 4:
                            gak1_4.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak1_4.Checked = true;
                            break;
                        case 5:
                            gak1_5.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak1_5.Checked = true;
                            break;
                        case 6:
                            gak1_6.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak1_6.Checked = true;
                            break;
                        case 7:
                            gak1_7.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak1_7.Checked = true;
                            break;
                        case 8:
                            gak1_8.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak1_8.Checked = true;
                            break;
                        case 9:
                            gak1_9.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak1_9.Checked = true;
                            break;
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 2) // 유물돌
            {
                if (global.cnt1 <= 10)
                {
                    global.N_silling += 1680;
                    UseS.Text = Convert.ToString(global.N_silling);
                    if (ran > global.percent) // 실패
                    {
                        if (global.percent != 75) global.percent += 10;
                        percent.Text = Convert.ToString(global.percent) + "%";
                        Suc = 0;
                    }
                    else // 성공
                    {
                        if (global.percent != 25) global.percent -= 10;
                        percent.Text = Convert.ToString(global.percent) + "%";
                        global.gakS1++;
                        gak1T.Text = "+" + Convert.ToString(global.gakS1);
                        Suc = 1;
                    }
                    switch (global.cnt1)
                    {
                        case 1:
                            gak1_1.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak1_1.Checked = true;
                            break;
                        case 2:
                            gak1_2.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak1_2.Checked = true;
                            break;
                        case 3:
                            gak1_3.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak1_3.Checked = true;
                            break;
                        case 4:
                            gak1_4.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak1_4.Checked = true;
                            break;
                        case 5:
                            gak1_5.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak1_5.Checked = true;
                            break;
                        case 6:
                            gak1_6.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak1_6.Checked = true;
                            break;
                        case 7:
                            gak1_7.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak1_7.Checked = true;
                            break;
                        case 8:
                            gak1_8.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak1_8.Checked = true;
                            break;
                        case 9:
                            gak1_9.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak1_9.Checked = true;
                            break;
                        case 10:
                            gak1_10.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak1_10.Checked = true;
                            break;

                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) // 각인2
        {
            global.cnt2++;
            Random rand = new Random();
            int ran = rand.Next(0, 100);
            int Suc;

            if (comboBox1.SelectedIndex == 0)       // 영웅돌
            {
                if (global.cnt2 <= 8)
                {
                    global.N_silling += 1160;
                    UseS.Text = Convert.ToString(global.N_silling);
                    if (ran > global.percent) // 실패
                    {
                        if (global.percent != 75) global.percent += 10;
                        percent.Text = Convert.ToString(global.percent) + "%";
                        Suc = 0;
                    }
                    else // 성공
                    {
                        if (global.percent != 25) global.percent -= 10;
                        percent.Text = Convert.ToString(global.percent) + "%";
                        global.gakS2++;
                        gak2T.Text = "+" + Convert.ToString(global.gakS2);
                        Suc = 1;
                    }
                    switch (global.cnt2)
                    {
                        case 1:
                            gak2_1.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak2_1.Checked = true;
                            break;
                        case 2:
                            gak2_2.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak2_2.Checked = true;
                            break;
                        case 3:
                            gak2_3.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak2_3.Checked = true;
                            break;
                        case 4:
                            gak2_4.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak2_4.Checked = true;
                            break;
                        case 5:
                            gak2_5.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak2_5.Checked = true;
                            break;
                        case 6:
                            gak2_6.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak2_6.Checked = true;
                            break;
                        case 7:
                            gak2_7.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak2_7.Checked = true;
                            break;
                        case 8:
                            gak2_8.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak2_8.Checked = true;
                            break;
                    }
                }

            }
            else if (comboBox1.SelectedIndex == 1) // 전설돌
            {
                if (global.cnt2 <= 9)
                {
                    global.N_silling += 1395;
                    UseS.Text = Convert.ToString(global.N_silling);
                    if (ran > global.percent) // 실패
                    {
                        if (global.percent != 75) global.percent += 10;
                        percent.Text = Convert.ToString(global.percent) + "%";
                        Suc = 0;
                    }
                    else // 성공
                    {
                        if (global.percent != 25) global.percent -= 10;
                        percent.Text = Convert.ToString(global.percent) + "%";
                        global.gakS2++;
                        gak2T.Text = "+" + Convert.ToString(global.gakS2);
                        Suc = 1;
                    }
                    switch (global.cnt2)
                    {
                        case 1:
                            gak2_1.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak2_1.Checked = true;
                            break;
                        case 2:
                            gak2_2.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak2_2.Checked = true;
                            break;
                        case 3:
                            gak2_3.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak2_3.Checked = true;
                            break;
                        case 4:
                            gak2_4.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak2_4.Checked = true;
                            break;
                        case 5:
                            gak2_5.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak2_5.Checked = true;
                            break;
                        case 6:
                            gak2_6.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak2_6.Checked = true;
                            break;
                        case 7:
                            gak2_7.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak2_7.Checked = true;
                            break;
                        case 8:
                            gak2_8.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak2_8.Checked = true;
                            break;
                        case 9:
                            gak2_9.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak2_9.Checked = true;
                            break;
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 2) // 유물돌
            {
                if (global.cnt2 <= 10)
                {
                    global.N_silling += 1680;
                    UseS.Text = Convert.ToString(global.N_silling);
                    if (ran > global.percent) // 실패
                    {
                        if (global.percent != 75) global.percent += 10;
                        percent.Text = Convert.ToString(global.percent) + "%";
                        Suc = 0;
                    }
                    else // 성공
                    {
                        if (global.percent != 25) global.percent -= 10;
                        percent.Text = Convert.ToString(global.percent) + "%";
                        global.gakS2++;
                        gak2T.Text = "+" + Convert.ToString(global.gakS2);
                        Suc = 1;
                    }
                    switch (global.cnt2)
                    {
                        case 1:
                            gak2_1.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak2_1.Checked = true;
                            break;
                        case 2:
                            gak2_2.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak2_2.Checked = true;
                            break;
                        case 3:
                            gak2_3.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak2_3.Checked = true;
                            break;
                        case 4:
                            gak2_4.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak2_4.Checked = true;
                            break;
                        case 5:
                            gak2_5.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak2_5.Checked = true;
                            break;
                        case 6:
                            gak2_6.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak2_6.Checked = true;
                            break;
                        case 7:
                            gak2_7.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak2_7.Checked = true;
                            break;
                        case 8:
                            gak2_8.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak2_8.Checked = true;
                            break;
                        case 9:
                            gak2_9.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak2_9.Checked = true;
                            break;
                        case 10:
                            gak2_10.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak2_10.Checked = true;
                            break;

                    }
                }
            }
        }
        private void button3_Click(object sender, EventArgs e) // 각인3
        {
            global.cnt3++;
            Random rand = new Random();
            int ran = rand.Next(0, 100);
            int Suc;

            if (comboBox1.SelectedIndex == 0)       // 영웅돌
            {
                if (global.cnt3 <= 8)
                {
                    global.N_silling += 1160;
                    UseS.Text = Convert.ToString(global.N_silling);
                    if (ran > global.percent) // 실패
                    {
                        if (global.percent != 75) global.percent += 10;
                        percent.Text = Convert.ToString(global.percent) + "%";
                        Suc = 0;
                    }
                    else // 성공
                    {
                        if (global.percent != 25) global.percent -= 10;
                        percent.Text = Convert.ToString(global.percent) + "%";
                        global.gakS3++;
                        gak3T.Text = "+" + Convert.ToString(global.gakS3);
                        Suc = 1;
                    }
                    switch (global.cnt3)
                    {
                        case 1:
                            gak3_1.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak3_1.Checked = true;
                            break;
                        case 2:
                            gak3_2.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak3_2.Checked = true;
                            break;
                        case 3:
                            gak3_3.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak3_3.Checked = true;
                            break;
                        case 4:
                            gak3_4.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak3_4.Checked = true;
                            break;
                        case 5:
                            gak3_5.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak3_5.Checked = true;
                            break;
                        case 6:
                            gak3_6.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak3_6.Checked = true;
                            break;
                        case 7:
                            gak3_7.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak3_7.Checked = true;
                            break;
                        case 8:
                            gak3_8.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak3_8.Checked = true;
                            break;
                    }
                }

            }
            else if (comboBox1.SelectedIndex == 1) // 전설돌
            {
                if (global.cnt3 <= 9)
                {
                    global.N_silling += 1395;
                    UseS.Text = Convert.ToString(global.N_silling);
                    if (ran > global.percent) // 실패
                    {
                        if (global.percent != 75) global.percent += 10;
                        percent.Text = Convert.ToString(global.percent) + "%";
                        Suc = 0;
                    }
                    else // 성공
                    {
                        if (global.percent != 25) global.percent -= 10;
                        percent.Text = Convert.ToString(global.percent) + "%";
                        global.gakS3++;
                        gak3T.Text = "+" + Convert.ToString(global.gakS3);
                        Suc = 1;
                    }
                    switch (global.cnt3)
                    {
                        case 1:
                            gak3_1.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak3_1.Checked = true;
                            break;
                        case 2:
                            gak3_2.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak3_2.Checked = true;
                            break;
                        case 3:
                            gak3_3.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak3_3.Checked = true;
                            break;
                        case 4:
                            gak3_4.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak3_4.Checked = true;
                            break;
                        case 5:
                            gak3_5.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak3_5.Checked = true;
                            break;
                        case 6:
                            gak3_6.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak3_6.Checked = true;
                            break;
                        case 7:
                            gak3_7.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak3_7.Checked = true;
                            break;
                        case 8:
                            gak3_8.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak3_8.Checked = true;
                            break;
                        case 9:
                            gak3_9.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak3_9.Checked = true;
                            break;
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 2) // 유물돌
            {
                if (global.cnt3 <= 10)
                {
                    global.N_silling += 1680;
                    UseS.Text = Convert.ToString(global.N_silling);
                    if (ran > global.percent) // 실패
                    {
                        if (global.percent != 75) global.percent += 10;
                        percent.Text = Convert.ToString(global.percent) + "%";
                        Suc = 0;
                    }
                    else // 성공
                    {
                        if (global.percent != 25) global.percent -= 10;
                        percent.Text = Convert.ToString(global.percent) + "%";
                        global.gakS3++;
                        gak3T.Text = "+" + Convert.ToString(global.gakS3);
                        Suc = 1;
                    }
                    switch (global.cnt3)
                    {
                        case 1:
                            gak3_1.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak3_1.Checked = true;
                            break;
                        case 2:
                            gak3_2.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak3_2.Checked = true;
                            break;
                        case 3:
                            gak3_3.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak3_3.Checked = true;
                            break;
                        case 4:
                            gak3_4.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak3_4.Checked = true;
                            break;
                        case 5:
                            gak3_5.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak3_5.Checked = true;
                            break;
                        case 6:
                            gak3_6.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak3_6.Checked = true;
                            break;
                        case 7:
                            gak3_7.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak3_7.Checked = true;
                            break;
                        case 8:
                            gak3_8.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak3_8.Checked = true;
                            break;
                        case 9:
                            gak3_9.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak3_9.Checked = true;
                            break;
                        case 10:
                            gak3_10.BackColor = Suc == 1 ? Color.Green : Color.Red;
                            gak3_10.Checked = true;
                            break;

                    }
                }
            }
        }
        private void NextS_Click(object sender, EventArgs e) // 다음돌 버튼
        {
            int n = 0;
            global.cnt1 = 0;
            global.cnt2 = 0;
            global.cnt3 = 0;
            global.gakS1 = 0;
            global.gakS2 = 0;
            global.gakS3 = 0;
            global.percent = 75;
            percent.Text = "75%";
            gak1T.Text = "0";
            gak2T.Text = "0";
            gak3T.Text = "0";
            gak1_1.BackColor = Color.Transparent;
            gak1_2.BackColor = Color.Transparent;
            gak1_3.BackColor = Color.Transparent;
            gak1_4.BackColor = Color.Transparent;
            gak1_5.BackColor = Color.Transparent;
            gak1_6.BackColor = Color.Transparent;
            gak1_7.BackColor = Color.Transparent;
            gak1_8.BackColor = Color.Transparent;
            gak1_9.BackColor = Color.Transparent;
            gak1_10.BackColor = Color.Transparent;
            gak2_1.BackColor = Color.Transparent;
            gak2_2.BackColor = Color.Transparent;
            gak2_3.BackColor = Color.Transparent;
            gak2_4.BackColor = Color.Transparent;
            gak2_5.BackColor = Color.Transparent;
            gak2_6.BackColor = Color.Transparent;
            gak2_7.BackColor = Color.Transparent;
            gak2_8.BackColor = Color.Transparent;
            gak2_9.BackColor = Color.Transparent;
            gak2_10.BackColor = Color.Transparent;
            gak3_1.BackColor = Color.Transparent;
            gak3_2.BackColor = Color.Transparent;
            gak3_3.BackColor = Color.Transparent;
            gak3_4.BackColor = Color.Transparent;
            gak3_5.BackColor = Color.Transparent;
            gak3_6.BackColor = Color.Transparent;
            gak3_7.BackColor = Color.Transparent;
            gak3_8.BackColor = Color.Transparent;
            gak3_9.BackColor = Color.Transparent;
            gak3_10.BackColor = Color.Transparent;

            if (GoldIn.Text != "")
            {
                n = Convert.ToInt32(GoldIn.Text);
            }

            if (comboBox1.SelectedIndex == 0)      // 영웅돌
            {
                global.N_peon += 5;
                global.N_gold += n;
                UseP.Text = Convert.ToString(global.N_peon);
                UseG.Text = Convert.ToString(global.N_gold);
            }
            else if (comboBox1.SelectedIndex == 1) // 전설돌
            {
                global.N_peon += 7;
                global.N_gold += n;
                UseP.Text = Convert.ToString(global.N_peon);
                UseG.Text = Convert.ToString(global.N_gold);
            }
            else if (comboBox1.SelectedIndex == 2) // 유물돌
            {
                global.N_peon += 9;
                global.N_gold += n;
                UseP.Text = Convert.ToString(global.N_peon);
                UseG.Text = Convert.ToString(global.N_gold);
            }
        }

        private void ini_Click(object sender, EventArgs e) //초기화 버튼
        {
            int n = 0;
            global.N_silling = 0;
            global.N_peon = 0;
            global.N_gold = 0;
            global.cnt1 = 0;
            global.cnt2 = 0;
            global.cnt3 = 0;
            global.percent = 75;
            global.gakS1 = 0;
            global.gakS2 = 0;
            global.gakS3 = 0;
            gak1T.Text = "0";
            gak2T.Text = "0";
            gak3T.Text = "0";
            UseS.Text = Convert.ToString(global.N_silling);
            UseG.Text = Convert.ToString(global.N_gold);
            UseP.Text = Convert.ToString(global.N_peon);
            percent.Text = "75%";
            gak1_1.BackColor = Color.Transparent;
            gak1_2.BackColor = Color.Transparent;
            gak1_3.BackColor = Color.Transparent;
            gak1_4.BackColor = Color.Transparent;
            gak1_5.BackColor = Color.Transparent;
            gak1_6.BackColor = Color.Transparent;
            gak1_7.BackColor = Color.Transparent;
            gak1_8.BackColor = Color.Transparent;
            gak1_9.BackColor = Color.Transparent;
            gak1_10.BackColor = Color.Transparent;
            gak2_1.BackColor = Color.Transparent;
            gak2_2.BackColor = Color.Transparent;
            gak2_3.BackColor = Color.Transparent;
            gak2_4.BackColor = Color.Transparent;
            gak2_5.BackColor = Color.Transparent;
            gak2_6.BackColor = Color.Transparent;
            gak2_7.BackColor = Color.Transparent;
            gak2_8.BackColor = Color.Transparent;
            gak2_9.BackColor = Color.Transparent;
            gak2_10.BackColor = Color.Transparent;
            gak3_1.BackColor = Color.Transparent;
            gak3_2.BackColor = Color.Transparent;
            gak3_3.BackColor = Color.Transparent;
            gak3_4.BackColor = Color.Transparent;
            gak3_5.BackColor = Color.Transparent;
            gak3_6.BackColor = Color.Transparent;
            gak3_7.BackColor = Color.Transparent;
            gak3_8.BackColor = Color.Transparent;
            gak3_9.BackColor = Color.Transparent;
            gak3_10.BackColor = Color.Transparent;
            if (GoldIn.Text != "")
            {
                n = Convert.ToInt32(GoldIn.Text);
            }
            if (comboBox1.SelectedIndex == 0)      // 영웅돌
            {
                global.N_peon += 5;
                global.N_gold += n;
                UseP.Text = Convert.ToString(global.N_peon);
                UseG.Text = Convert.ToString(global.N_gold);
            }
            else if (comboBox1.SelectedIndex == 1) // 전설돌
            {
                global.N_peon += 7;
                global.N_gold += n;
                UseP.Text = Convert.ToString(global.N_peon);
                UseG.Text = Convert.ToString(global.N_gold);
            }
            else if (comboBox1.SelectedIndex == 2) // 유물돌
            {
                global.N_peon += 9;
                global.N_gold += n;
                UseP.Text = Convert.ToString(global.N_peon);
                UseG.Text = Convert.ToString(global.N_gold);
            }
        }
        private void GoldIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8))  // 숫자랑 벡스페만 받음
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}