using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp28.Classs;

namespace WindowsFormsApp28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CustomerDal.connectionstring = txtsqlconnectionstring.Text;
          

            timer1.Interval = 100;
            timer2.Interval = 25;
            timer3.Interval = 25;


            panel6.BackColor = Color.FromArgb(100, 100, 100);




        }

        private void button21_Click(object sender, EventArgs e)
        {
            /*con = new SqlConnection(txtsqlconnectionstring.Text);
            cmd = new SqlCommand("select * from Customer where card_code=@code and passaword=@pass", con);
            cmd.Parameters.AddWithValue("@code", txtcardcode.Text);
            cmd.Parameters.AddWithValue("@pass", richTextBox1.Text);
            con.Open();
            dr = cmd.ExecuteReader();*/

            if (CustomerDal.ControlPassaword(richTextBox1.Text, txtcardcode.Text))
            {
                //MessageBox.Show("Giris Basarili");

                richTextBox1.Visible = false;
                lblpassawordc.Visible = false;
                //ekran kirmizi ana  menu secenekleri

                MainMenuVisible(true);

                // ekranin yan tuslari



                ScreenKeysEnabled(true);

                //yesil buton false edilir
                button21.Enabled = false;

                richTextBox1.Text = "";

            }

            else
            {
                MessageBox.Show("Giris basarisiz");
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {


            /*string conectionstring = txtsqlconnectionstring.Text;
            con = new SqlConnection(conectionstring);
            cmd = new SqlCommand("select * from Customer where card_code=@code", con);
            cmd.Parameters.AddWithValue("@code", txtcardcode.Text);
            con.Open();
            dr = cmd.ExecuteReader();*/

            if (CustomerDal.ControlCardCode(txtcardcode.Text))
            {
                panel3.BackColor = Color.Green;

                lblLoad.Visible = false;
                lblWelcome.Visible = false;
                lblPlase.Visible = false;
                lblnocard.Visible = false;
                richTextBox1.Visible = true;
                lblpassawordc.Visible = true;

                txtcardcode.Enabled = false;
                txtsqlconnectionstring.Enabled = false;
                button25.Enabled = false;

                button21.Enabled = true;

                NumberKeysEnabled(true);


                // MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
            }

            else
            {
                panel3.BackColor = Color.Red;
                lblLoad.Visible = false;
                lblWelcome.Visible = false;
                lblPlase.Visible = false;
                lblnocard.Visible = true;
                // MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            // con.Close();








        }

        private void txtcardcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsqlconnectionstring_TextChanged(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Visible == true)
            {
                richTextBox1.Text = richTextBox1.Text + "1";
            }

            if (txtwithdrawnamount.Visible == true)
            {
                txtwithdrawnamount.Text = txtwithdrawnamount.Text + "1";
            }
            if (txtmoneyagetdrawn.Visible == true)
            {
                txtmoneyagetdrawn.Text = txtmoneyagetdrawn.Text + "1";
            }
            if (txtacountnumber.Visible == true)
            {
                txtacountnumber.Text = txtacountnumber.Text + "1";
            }
            if (txtamounteft.Visible == true)
            {
                txtamounteft.Text = txtamounteft.Text + "1";

            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Visible == true)
            {
                richTextBox1.Text = richTextBox1.Text + "2";
            }

            if (txtwithdrawnamount.Visible == true)
            {
                txtwithdrawnamount.Text = txtwithdrawnamount.Text + "2";
            }
            if (txtmoneyagetdrawn.Visible == true)
            {
                txtmoneyagetdrawn.Text = txtmoneyagetdrawn.Text + "2";
            }
            if (txtacountnumber.Visible == true)
            {
                txtacountnumber.Text = txtacountnumber.Text + "2";
            }
            if (txtamounteft.Visible == true)
            {
                txtamounteft.Text = txtamounteft.Text + "2";

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Visible == true)
            {
                richTextBox1.Text = richTextBox1.Text + "3";
            }

            if (txtwithdrawnamount.Visible == true)
            {
                txtwithdrawnamount.Text = txtwithdrawnamount.Text + "3";
            }
            if (txtmoneyagetdrawn.Visible == true)
            {
                txtmoneyagetdrawn.Text = txtmoneyagetdrawn.Text + "3";
            }
            if (txtacountnumber.Visible == true)
            {
                txtacountnumber.Text = txtacountnumber.Text + "3";
            }
            if (txtamounteft.Visible == true)
            {
                txtamounteft.Text = txtamounteft.Text + "3";

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Visible == true)
            {
                richTextBox1.Text = richTextBox1.Text + "4";
            }

            if (txtwithdrawnamount.Visible == true)
            {
                txtwithdrawnamount.Text = txtwithdrawnamount.Text + "4";
            }
            if (txtmoneyagetdrawn.Visible == true)
            {
                txtmoneyagetdrawn.Text = txtmoneyagetdrawn.Text + "4";
            }
            if (txtacountnumber.Visible == true)
            {
                txtacountnumber.Text = txtacountnumber.Text + "4";
            }
            if (txtamounteft.Visible == true)
            {
                txtamounteft.Text = txtamounteft.Text + "4";

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Visible == true)
            {
                richTextBox1.Text = richTextBox1.Text + "5";
            }

            if (txtwithdrawnamount.Visible == true)
            {
                txtwithdrawnamount.Text = txtwithdrawnamount.Text + "5";
            }
            if (txtmoneyagetdrawn.Visible == true)
            {
                txtmoneyagetdrawn.Text = txtmoneyagetdrawn.Text + "5";
            }
            if (txtacountnumber.Visible == true)
            {
                txtacountnumber.Text = txtacountnumber.Text + "5";
            }
            if (txtamounteft.Visible == true)
            {
                txtamounteft.Text = txtamounteft.Text + "5";

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Visible == true)
            {
                richTextBox1.Text = richTextBox1.Text + "6";
            }

            if (txtwithdrawnamount.Visible == true)
            {
                txtwithdrawnamount.Text = txtwithdrawnamount.Text + "6";
            }
            if (txtmoneyagetdrawn.Visible == true)
            {
                txtmoneyagetdrawn.Text = txtmoneyagetdrawn.Text + "6";
            }
            if (txtacountnumber.Visible == true)
            {
                txtacountnumber.Text = txtacountnumber.Text + "6";
            }
            if (txtamounteft.Visible == true)
            {
                txtamounteft.Text = txtamounteft.Text + "6";

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Visible == true)
            {
                richTextBox1.Text = richTextBox1.Text + "7";
            }

            if (txtwithdrawnamount.Visible == true)
            {
                txtwithdrawnamount.Text = txtwithdrawnamount.Text + "7";
            }
            if (txtmoneyagetdrawn.Visible == true)
            {
                txtmoneyagetdrawn.Text = txtmoneyagetdrawn.Text + "7";
            }
            if (txtacountnumber.Visible == true)
            {
                txtacountnumber.Text = txtacountnumber.Text + "7";
            }
            if (txtamounteft.Visible == true)
            {
                txtamounteft.Text = txtamounteft.Text + "7";

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Visible == true)
            {
                richTextBox1.Text = richTextBox1.Text + "8";
            }

            if (txtwithdrawnamount.Visible == true)
            {
                txtwithdrawnamount.Text = txtwithdrawnamount.Text + "8";
            }
            if (txtmoneyagetdrawn.Visible == true)
            {
                txtmoneyagetdrawn.Text = txtmoneyagetdrawn.Text + "8";
            }
            if (txtacountnumber.Visible == true)
            {
                txtacountnumber.Text = txtacountnumber.Text + "8";
            }
            if (txtamounteft.Visible == true)
            {
                txtamounteft.Text = txtamounteft.Text + "8";

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Visible == true)
            {
                richTextBox1.Text = richTextBox1.Text + "9";
            }

            if (txtwithdrawnamount.Visible == true)
            {
                txtwithdrawnamount.Text = txtwithdrawnamount.Text + "9";
            }
            if (txtmoneyagetdrawn.Visible == true)
            {
                txtmoneyagetdrawn.Text = txtmoneyagetdrawn.Text + "9";
            }
            if (txtacountnumber.Visible == true)
            {
                txtacountnumber.Text = txtacountnumber.Text + "9";
            }
            if (txtamounteft.Visible == true)
            {
                txtamounteft.Text = txtamounteft.Text + "9";

            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Visible == true)
            {
                richTextBox1.Text = richTextBox1.Text + "0";
            }

            if (txtwithdrawnamount.Visible == true)
            {
                txtwithdrawnamount.Text = txtwithdrawnamount.Text + "0";
            }
            if (txtmoneyagetdrawn.Visible == true)
            {
                txtmoneyagetdrawn.Text = txtmoneyagetdrawn.Text + "0";
            }
            if (txtacountnumber.Visible == true)
            {
                txtacountnumber.Text = txtacountnumber.Text + "0";
            }
            if (txtamounteft.Visible == true)
            {
                txtamounteft.Text = txtamounteft.Text + "0";

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button17.Visible == true)
            {
                button17_Click_1(sender, e);
            }

            if (button9.Visible == true)
            {
                button9_Click_1(sender, e);
            }


        }

        public void WithdrawnAmountVisible(bool bo)
        {
            button17.Visible = bo;
            button22.Visible = bo;
            button26.Visible = bo;
            button27.Visible = bo;
            button28.Visible = bo;
            button29.Visible = bo;
            button30.Visible = bo;
            button31.Visible = bo;
        }
        public void MainMenuVisible(bool bo)
        {
            button9.Visible = bo;
            button10.Visible = bo;
            button11.Visible = bo;
            button12.Visible = bo;
            button13.Visible = bo;
            button14.Visible = bo;
            button15.Visible = bo;
            button16.Visible = bo;
        }

        public void NumberKeysEnabled(bool bo)
        {
            btn0.Enabled = bo;
            btn1.Enabled = bo;
            btn2.Enabled = bo;
            btn3.Enabled = bo;
            btn4.Enabled = bo;
            btn5.Enabled = bo;
            btn6.Enabled = bo;
            btn7.Enabled = bo;
            btn8.Enabled = bo;
            btn9.Enabled = bo;
            button23.Enabled = bo;
            button24.Enabled = bo;

        }

        public void ScreenKeysEnabled(bool bo)
        {
            button1.Enabled = bo;
            button2.Enabled = bo;
            button3.Enabled = bo;
            button4.Enabled = bo;
            button5.Enabled = bo;
            button6.Enabled = bo;
            button7.Enabled = bo;
            button8.Enabled = bo;
        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            MainMenuVisible(false);

            WithdrawnAmountVisible(true);
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            WithDrawnAmountApply(button17.Text);
        }

        decimal Withdrawnamountapply;
        public void WithDrawnAmountApply(String amount)
        {
            WithdrawnAmountVisible(false);
            lblWidtDrawnAmountApply.Text = "Çekilecek Tutar : " + amount + "\n     Onaylıyor musunuz ?";
            lblWidtDrawnAmountApply.Visible = true;
            btnnoapply.Visible = true;
            btnapply.Visible = true;


            try
            {
                Withdrawnamountapply = Convert.ToDecimal((amount.Substring(0, 4)).Trim());
            }
            catch (Exception)
            {

                Withdrawnamountapply = Convert.ToDecimal((amount.Substring(0, amount.Length)).Trim());
            }




        }

        private void btnapply_Click(object sender, EventArgs e)
        {
            if (CustomerDal.AmountQuery(new Customer() { CardCode = txtcardcode.Text, Balance = Withdrawnamountapply }))
            {

                CustomerDal.BalanceUpdate(new Customer() { CardCode = txtcardcode.Text }, Withdrawnamountapply);
                //  MessageBox.Show("Islem Basarili");
                // onay sorusunu cevapllayinca  gizlensinler
                btnapply.Visible = false;
                btnnoapply.Visible = false;
                lblWidtDrawnAmountApply.Visible = false;

                lblGetMoney.Visible = true;
                timer1.Start();


                // para  cikisi  panelinin gorsel  gelistirme  calistmasi 
                timer2.Start();

            }


            else
            {
                btnapply.Visible = false;
                btnnoapply.Visible = false;
                lblWidtDrawnAmountApply.Visible = false;
                lbl0amount.Visible = true;
                button32.Visible = true;
                button33.Visible = true;
            }


        }

        public void TimerStart()
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {
            // parayi  aldiktan  sonra
            btnGetMoney.Visible = false;
            timer1.Stop();
            panel4.BackColor = Color.Silver;
            lblGetMoney.Visible = false;

            // para  panel  gorsel calismasi geri kapatma
            timer3.Start();
            button32.Visible = true;
            button33.Visible = true;

            // panel6.BackColor = Color.FromArgb(100, 100, 100);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
          
            
            if (button32.Visible == true)
            {
                button32_Click_1(sender, e);
            }
            //EFT 2
            if (button40.Visible == true)
            {
                button40_Click(sender, e);
            }
            if (button34.Visible == true)
            {
                button34_Click_1(sender, e);
            }
            //EFT 1 
            if (button36.Visible == true)
            {
                button36_Click(sender, e);
            }

            if (btnapply.Visible == true)
            {
                btnapply_Click(sender, e);
            }

            if (button37.Visible == true)
            {
                button37_Click(sender, e);
            }

            if (button31.Visible == true)
            {
                button31_Click(sender, e);
            }


        }

        int timer = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer % 2 == 0)
            {
                panel4.BackColor = Color.Green;

            }

            else
            {
                panel4.BackColor = Color.Silver;
            }

            timer++;

            if (timer > 1)
            {
                timer = 0;
            }
        }



        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Silver;

            lblLoad.Visible = true;
            lblWelcome.Visible = true;
            lblPlase.Visible = true;
            lblnocard.Visible = false;
            richTextBox1.Visible = false;
            lblpassawordc.Visible = false;

            txtcardcode.Enabled = true;
            txtsqlconnectionstring.Enabled = true;
            button25.Enabled = true;

            button21.Enabled = true;

            NumberKeysEnabled(false);

            MainMenuVisible(false);
            WithdrawnAmountVisible(false);
            //yesil buton enabled false etme 
            button21.Enabled = false;
            // para cekilirken onay butonlari yes/no
            btnnoapply.Visible = false;
            btnapply.Visible = false;
            lblWidtDrawnAmountApply.Visible = false;


            //para  cekilden  sonra  cikis butonu ve menu  butonu  gizleme
            button32.Visible = false;
            button33.Visible = false;

            //clear reactextboxpas
            richTextBox1.Text = "";

            //elle girilen  tutar giris  ekranindayken exit  isleminde visible false et

            gbxdifwithdrawnamount.Visible = false;

            gbxmoneyeft1.Visible = false;
            gbxmoneyeft2.Visible = false;

            gbxusedbalance.Visible = false;


            //basarili gonderim bildir  label  ini false et 

            lbleftapply.Visible = false;

        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            WithDrawnAmountApply(button22.Text);
        }

        private void button26_Click_1(object sender, EventArgs e)
        {
            WithDrawnAmountApply(button26.Text);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            WithDrawnAmountApply(button27.Text);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            WithDrawnAmountApply(button28.Text);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            WithDrawnAmountApply(button29.Text);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            WithDrawnAmountApply(button30.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button22.Visible == true)
            {
                button22_Click_1(sender, e);
            }
            if (button10.Visible == true)
            {
                button10_Click_1(sender, e);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button11.Visible == true)
            {
                button11_Click_1(sender, e);
            }
            if (button26.Visible == true)
            {
                button26_Click_1(sender, e);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button41.Visible == true)
            {
                button41_Click(sender, e);
            }
            //Eft1
            if (button39.Visible == true)
            {
                button39_Click(sender, e);
            }
            //menu
            if (button33.Visible == true)
            {
                button33_Click(sender, e);
            }
            //menu
            if (button38.Visible == true)
            {
                button33_Click(sender, e);
            }
            //menu 
            if (button35.Visible == true)
            {
                button33_Click(sender, e);
            }
            if (btnnoapply.Visible == true)
            {
                btnnoapply_Click(sender, e);
            }
            //300
            if (button27.Visible == true)
            {
                button27_Click(sender, e);
            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button13.Visible == true)
            {
                button13_Click_1(sender, e);
            }

            //200
            if (button28.Visible == true)
            {
                button28_Click(sender, e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button29.Visible == true)
            {
                button29_Click(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button30.Visible == true)
            {
                button30_Click(sender, e);
            }
        }


        int r = 100;
        private void timer2_Tick_1(object sender, EventArgs e)
        {

            if (r == 0)
            {
                timer2.Stop();
                if (lblGetMoney.Visible == true)
                {
                    btnGetMoney.Visible = true;
                }

                else
                {
                    btnSetMoney.Visible = true;
                }

            }

            else
            {
                r--;
                panel6.BackColor = Color.FromArgb(r, r, r);
            }


        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (r == 100)
            {
                timer3.Stop();
            }

            else
            {
                r++;
                panel6.BackColor = Color.FromArgb(r, r, r);
            }

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            NumberKeysEnabled(true);
            MainMenuVisible(false);
            gbxnogetdtawn.Visible = true;
        }


        //elle girilen  tutardan sonra next  islemi
        private void button32_Click_1(object sender, EventArgs e)
        {
            /*WithDrawnAmountApply(txtwithdrawnamount.Text);
            gbxdifwithdrawnamount.Visible = false;
            btnapply.Visible = true;
            btnnoapply.Visible = true;*/

            button18_Click(sender, e);

            lbl0amount.Visible = false;

        }

        private void button33_Click(object sender, EventArgs e)
        {
            //ekran kirmizi ana  menu secenekleri

            MainMenuVisible(true);
            button33.Visible = false;
            button32.Visible = false;

            // ekranin yan tuslari



            ScreenKeysEnabled(true);

            // gbxini gizle
            gbxdifwithdrawnamount.Visible = false;
            gbxnogetdtawn.Visible = false;
            gbxusedbalance.Visible = false;

            lbl0amount.Visible = false;

            //gxusedbalance gizle

            lbleftapply.Visible = false;
        }

        private void timeron_Tick(object sender, EventArgs e)
        {
            if (r == 0)
            {
                timer1.Stop();
            }

            else
            {
                r--;
                this.BackColor = Color.FromArgb(r, r, r);
            }
        }

        private void timeroff_Tick(object sender, EventArgs e)
        {
            if (r == 100)
            {
                timer2.Stop();
            }
            else
            {
                r++;
                this.BackColor = Color.FromArgb(r, r, r);
            }
        }

        // string passaword = "";
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {






            // sadece  4 number girisini saglamasi adina  yapilan events
            if (richTextBox1.Text.Length == 4)
            {

                NumberKeysEnabled(false);

            }

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (txtamounteft.Visible == true)
            {
                if (txtamounteft.Text != "")
                {
                    txtamounteft.Text = txtamounteft.Text.Substring(0, (txtamounteft.Text.Length - 1));
                }
            }
            if (txtacountnumber.Visible == true)
            {
                if (txtacountnumber.Text != "")
                {
                    txtacountnumber.Text = txtacountnumber.Text.Substring(0, (txtacountnumber.Text.Length - 1));
                }
            }
            if (richTextBox1.Visible == true)
            {
                if (richTextBox1.Text.Length != 0)
                {
                    richTextBox1.Text = richTextBox1.Text.Substring(0, (richTextBox1.Text.Length - 1));
                    NumberKeysEnabled(true);
                }
            }

            if (txtwithdrawnamount.Visible == true)
            {

                if (txtwithdrawnamount.Text.Length != 0)
                {
                    txtwithdrawnamount.Text = txtwithdrawnamount.Text.Substring(0, (txtwithdrawnamount.Text.Length - 1));
                    NumberKeysEnabled(true);
                    lblmax5000.Visible = false;
                }

            }
            if (txtmoneyagetdrawn.Visible == true)
            {

                if (txtmoneyagetdrawn.Text.Length != 0)
                {
                    txtmoneyagetdrawn.Text = txtmoneyagetdrawn.Text.Substring(0, (txtmoneyagetdrawn.Text.Length - 1));
                    NumberKeysEnabled(true);
                    // lblmax5000.Visible = false;
                }

            }

        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtwithdrawnamount.Text.Length == 4)
            {
                NumberKeysEnabled(false);
                if (Convert.ToInt32(txtwithdrawnamount.Text) > 5000)
                {
                    lblmax5000.Visible = true;
                }
            }
            if (txtwithdrawnamount.Text.Length == 1)
            {
                lblmin25.Visible = true;
            }

            if (txtwithdrawnamount.Text.Length == 2)
            {
                lblmin25.Visible = false;
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            WithdrawnAmountVisible(false);
            gbxdifwithdrawnamount.Visible = true;
            NumberKeysEnabled(true);

        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (txtwithdrawnamount.Text != "")
            {
                WithDrawnAmountApply(txtwithdrawnamount.Text);
                gbxdifwithdrawnamount.Visible = false;
                btnapply.Visible = true;
                btnnoapply.Visible = true;
            }

        }

        private void button38_Click(object sender, EventArgs e)
        {


            //ekran kirmizi ana  menu secenekleri

            // MainMenuVisible(true);
            // button33.Visible = false;
            //button32.Visible = false;

            // ekranin yan tuslari

            button33_Click(sender, e);
            txtmoneyagetdrawn.Text = "";

            // ScreenKeysEnabled(true);

            // txt bosalsin 
            txtmoneyagetdrawn.Text = "";
        }

        private void txtmoneyagetdrawn_TextChanged(object sender, EventArgs e)
        {
            if (txtmoneyagetdrawn.Text.Length == 4)
            {
                NumberKeysEnabled(false);
                if (Convert.ToInt32(txtmoneyagetdrawn.Text) > 5000)
                {
                    lblsetmax.Visible = true;
                }
            }
            if (txtmoneyagetdrawn.Text.Length == 1)
            {
                lblsetmin.Visible = true;
            }

            if (txtmoneyagetdrawn.Text.Length == 2)
            {
                lblsetmin.Visible = false;
            }
        }



        private void button36_Click(object sender, EventArgs e)
        {
            if (txtmoneyagetdrawn.Text != "")
            {
                CustomerDal.ABalanceUpdate(new Customer() { CardCode = txtcardcode.Text }, Convert.ToDecimal(txtmoneyagetdrawn.Text));

                // onay sorusunu cevapllayinca  gizlensinler
                gbxnogetdtawn.Visible = false;
                //btnapply.Visible = false;
                // btnnoapply.Visible = false;
                //lblWidtDrawnAmountApply.Visible = false;

                lblSetMoney.Visible = true;
                timer1.Start();


                // para  cikisi  panelinin gorsel  gelistirme  calistmasi 
                timer2.Start();

                //txt  bosalt
                txtmoneyagetdrawn.Text = "";
            }

        }

        private void btnSetMoney_Click(object sender, EventArgs e)
        {
            // parayi  koyduktan  sonra
            btnSetMoney.Visible = false;
            timer1.Stop();
            panel4.BackColor = Color.Silver;
            lblSetMoney.Visible = false;

            // para  panel  gorsel calismasi geri kapatma
            timer3.Start();
            button32.Visible = true;
            button33.Visible = true;

            // panel6.BackColor = Color.FromArgb(100, 100, 100);
        }

        private void btnnoapply_Click(object sender, EventArgs e)
        {
            btnapply.Visible = false;
            btnnoapply.Visible = false;
            lblWidtDrawnAmountApply.Visible = false;
            gbxdifwithdrawnamount.Visible = true;
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            MainMenuVisible(false);
            button33.Visible = true;
            button32.Visible = true;
            lblusedbalanceamount.Text = CustomerDal.GetBalance(new Customer() { CardCode = txtcardcode.Text }).ToString();
            gbxusedbalance.Visible = true;


        }

        private void button39_Click(object sender, EventArgs e)
        {
            button33_Click(sender, e);

            //groupboxini visible false et

            gbxmoneyeft1.Visible = false;
            txtacountnumber.Text = "";

            lblnoacountnumber.Visible = false;
        }

        string acountnumber;
        private void button34_Click_1(object sender, EventArgs e)
        {
            if (txtacountnumber.Text != "")
            {

                if (CustomerDal.AcountQuery(txtacountnumber.Text))
                {
                    lblnoacountnumber.Visible = false;
                    acountnumber = txtacountnumber.Text;

                    gbxmoneyeft1.Visible = false;

                    gbxmoneyeft2.Visible = true;
                    txtacountnumber.Text = "";
                    lblnoacountnumber.Visible = false;
                }

                else
                {
                    lblnoacountnumber.Visible = true;
                }








            }

        }

        private void button41_Click(object sender, EventArgs e)
        {
            gbxmoneyeft2.Visible = false;
            MainMenuVisible(true);
            lblinsufficionbalance.Visible = false;
            txtamounteft.Text = "";
            
        }


        private void button40_Click(object sender, EventArgs e)
        {
            if (txtamounteft.Text != "")
            {
                lblinsufficionbalance.Visible = false;
                Decimal eftamount = Convert.ToDecimal(txtamounteft.Text);
                if (CustomerDal.AmountQuery(new Customer() { CardCode=txtcardcode.Text,Balance=eftamount}))
                {
                    CustomerDal.BalanceUpdateAcountCon(acountnumber, eftamount);
                    CustomerDal.BalanceUpdate(new Customer() { CardCode = txtcardcode.Text }, eftamount);

                    NumberKeysEnabled(false);

                    button33.Visible = true;
                    button32.Visible = true;

                    //kendi  gbx ini false et

                    gbxmoneyeft2.Visible = false;

                    lbleftapply.Text = acountnumber + " Müşteri Numarasına \n" + txtamounteft.Text + " TL Başarılı Bir Şekilde Gönderildi";
                    lbleftapply.Visible = true;
                }

                else
                {
                    lblinsufficionbalance.Visible = true;
                }


                txtamounteft.Text = "";
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            MainMenuVisible(false);
            gbxmoneyeft1.Visible = true;
            NumberKeysEnabled(true);
        }
    }
}
