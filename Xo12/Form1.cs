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
namespace Xo12
{
    public partial class Form1 : Form
    {
       Boolean[] Halat=new Boolean[21];
        int[ , ] P=new int[25,7];
        int Old, Neew,Tedad1,Tedad2,t=1;
        Boolean Vaziat,Chek;
        string mohreB1, mohreB2,Rt,W,StrLst,StrHalat="",SHT;
        public string Np=string.Empty,TXt,Nam,Zakhire;

        public void TrOrFa(string H)
        {
            int P;
            for (int f = 1; f < 21; f++)
            {
                Halat[f] = false;
            }
                for (int k = 0; k < H.Length; k++)
                {
                    P = int.Parse(H.Substring(k, 1));
                    for (int S = 1; S < 21; S++)
                    {
                        if (S == P)
                            Halat[S] = true;
                    }
                }
        }
        public string TrueORFalse(Boolean[] R)
        {
            int F, G;
            for (int k = 1; k < 21; k++)
            {
                if (R[k] == true) StrHalat = StrHalat + k.ToString();
            }
            F = StrHalat.Length;
            G = 5 - F;
            for (int v = 0; v < G; v++)
            {
                StrHalat = StrHalat + "0";
            }
            return StrHalat;
        }
        public string savee(GroupBox h)
        {
            string tx = "",A="",B="",ns;
            int ls;
            if (X.Image == Ximage.Image) A = "X";
            else
                if (X.Image == Oimage.Image) A = "O";

            if (O.Image == Ximage.Image) B = "X";
            else
                if (O.Image == Oimage.Image) B = "O";
            for (int i = 23; i >= 0; i--)
            {
                ls = h.Controls[i].Name.Length;
                ns = h.Controls[i].Name;
                if (ls > 10 && ls<13)
                {
                    if (h.Controls[i].Tag.ToString() =="0") tx = tx + "0";
                    if (h.Controls[i].Tag.ToString() == "1") tx = tx + A;
                    if (h.Controls[i].Tag.ToString() == "2") tx = tx + B;
                }
            }
            return tx;
        }
        public string Mhr(PictureBox k)
        {
            string txt="";
            if (k.Image == Ximage.Image) txt = "X";
            else
            {
                if (k.Image == Oimage.Image) txt = "O";
            }
            return txt;
        }
        public string Esm(string k)
        {
            string Str = k;
            int a, b;
            a = k.Length;
            b = 20 - a;
            for (int c = 0; c < b; c++)
            {
                Str = Str + " ";
            }
            return Str;
        }
        public void TestDoz(int A)
        {
            switch (A)
            {
                case 1:
                    Halat[1] = false;
                    Halat[9]=false;
                    Halat[17]=false;
                    break;
                case 2:
                    Halat[1]=false;
                    Halat[12]=false;
                    break;
                case 3:
                    Halat[1]=false;
                    Halat[16]=false;
                    Halat[18]=false;
                    break;
                case 4:
                    Halat[2] = false;
                    Halat[10]=false;
                    Halat[17]=false;
                    break;
                case 5:
                    Halat[2]=false;
                    Halat[12]=false;
                    break;
                case 6:
                    Halat[2]=false;
                    Halat[15]=false;
                    Halat[18]=false;
                    break;
                case 7:
                    Halat[3]=false;
                    Halat[11]=false;
                    Halat[17]=false;
                    break;
                case 8:
                    Halat[3]=false;
                    Halat[12]=false;
                    break;
                case 9:
                    Halat[3]=false;
                    Halat[14]=false;
                    Halat[18]=false;
                    break;
                case 10:
                    Halat[4]=false;
                    Halat[9]=false;
                    break;
                case 11:
                    Halat[4]=false;
                    Halat[10]=false;
                    break;
                case 12:
                    Halat[4]=false;
                    Halat[11]=false;
                    break;
                case 13:
                    Halat[5]=false;
                    Halat[14]=false;
                    break;
                case 14:
                    Halat[5]=false;
                    Halat[15]=false;
                    break;
                case 15:
                    Halat[5]=false;
                    Halat[16]=false;
                    break;
                case 16:
                    Halat[6]=false;
                    Halat[11]=false;
                    Halat[19]=false;
                    break;
                case 17:
                    Halat[6]=false;
                    Halat[13]=false;
                    break;
                case 18:
                    Halat[6]=false;
                    Halat[14]=false;
                    Halat[20]=false;
                    break;
                case 19:
                    Halat[7]=false;
                    Halat[10]=false;
                    Halat[19]=false;
                    break;
                case 20:
                    Halat[7]=false;
                    Halat[13]=false;
                    break;
                case 21:
                    Halat[7]=false;
                    Halat[15]=false;
                    Halat[20]=false;
                    break;
                case 22:
                    Halat[8]=false;
                    Halat[9]=false;
                    Halat[19]=false;
                    break;
                case 23:
                    Halat[8]=false;
                    Halat[13]=false;
                    break;
                case 24:
                    Halat[8]=false;
                    Halat[16]=false;
                    Halat[20]=false;
                    break;
            }
        }
        
        public Boolean TestP(int K, int H)
        {
            Boolean F = false;
            for (int i = 1; i < 6; i++)
            {
                if (P[K, i] == H) F = true;
            }
            return F;
        }

        public string Xo(string Mohre)
        {
            string X = "000000";
            if (Halat[1] == false)
            {
                if (pictureBox1.Tag.ToString() == Mohre && pictureBox2.Tag.ToString() == Mohre && pictureBox3.Tag.ToString() == Mohre)
                {
                    X = "010203";
                    Halat[1] = true;
                }
            }
            if (Halat[2] == false)
            {
                if (pictureBox4.Tag.ToString() == Mohre && pictureBox5.Tag.ToString() == Mohre && pictureBox6.Tag.ToString() == Mohre)
                {
                    X = "040506";
                    Halat[2] = true;
                }
            }
            if (Halat[3] == false)
            {
                if (pictureBox7.Tag.ToString() == Mohre && pictureBox8.Tag.ToString() == Mohre && pictureBox9.Tag.ToString() == Mohre)
                {
                    X = "070809";
                    Halat[3] = true;
                }
            }
            if (Halat[4] == false)
            {
                if (pictureBox10.Tag.ToString() == Mohre && pictureBox11.Tag.ToString() == Mohre && pictureBox12.Tag.ToString() == Mohre)
                {
                    X = "101112";
                    Halat[4] = true;
                }
            }
            if (Halat[5] == false)
            {
                if (pictureBox13.Tag.ToString() == Mohre && pictureBox14.Tag.ToString() == Mohre && pictureBox15.Tag.ToString() == Mohre)
                {
                    X = "131415";
                    Halat[5] = true;
                }
            }
            if (Halat[6] == false)
            {
                if (pictureBox16.Tag.ToString() == Mohre && pictureBox17.Tag.ToString() == Mohre && pictureBox18.Tag.ToString() == Mohre)
                {
                     X = "161718";
                     Halat[6] = true;
                    }
            }
            if (Halat[7] == false)
            {
                if (pictureBox19.Tag.ToString() == Mohre && pictureBox20.Tag.ToString() == Mohre && pictureBox21.Tag.ToString() == Mohre)
                {
                    X = "192021";
                    Halat[7] = true;
                }
            }
            if (Halat[8] == false)
            {
                if (pictureBox22.Tag.ToString() == Mohre && pictureBox23.Tag.ToString() == Mohre && pictureBox24.Tag.ToString() == Mohre)
                {
                    X = "222324";
                    Halat[8] = true;
                }
            }
            if (Halat[9] == false)
            {
                if (pictureBox1.Tag.ToString() == Mohre && pictureBox10.Tag.ToString() == Mohre && pictureBox22.Tag.ToString() == Mohre)
                {
                    X = "011022";
                    Halat[9] = true;
                }
            }
            if (Halat[10] == false)
            {
                if (pictureBox4.Tag.ToString() == Mohre && pictureBox11.Tag.ToString() == Mohre && pictureBox19.Tag.ToString() == Mohre)
                {
                    X = "041119";
                    Halat[10] = true;
                }
            }
            if (Halat[11] == false)
            {
                if (pictureBox7.Tag.ToString() == Mohre && pictureBox12.Tag.ToString() == Mohre && pictureBox16.Tag.ToString() == Mohre)
                {
                    X = "071216";
                    Halat[11] = true;
                }
            }
            if (Halat[12] == false)
            {
                if (pictureBox2.Tag.ToString() == Mohre && pictureBox5.Tag.ToString() == Mohre && pictureBox8.Tag.ToString() == Mohre)
                {
                    X = "020508";
                    Halat[12] = true;
                }
            }
            if (Halat[13] == false)
            {
                if (pictureBox17.Tag.ToString() == Mohre && pictureBox20.Tag.ToString() == Mohre && pictureBox23.Tag.ToString() == Mohre)
                {
                    X = "172023";
                    Halat[13] = true;
                }
            }
            if (Halat[14] == false)
            {
                if (pictureBox9.Tag.ToString() == Mohre && pictureBox13.Tag.ToString() == Mohre && pictureBox18.Tag.ToString() == Mohre)
                {
                    X = "091318";
                    Halat[14] = true;
                }
            }
            if (Halat[15] == false)
            {
                if (pictureBox6.Tag.ToString() == Mohre && pictureBox14.Tag.ToString() == Mohre && pictureBox21.Tag.ToString() == Mohre)
                {
                    X = "061421";
                    Halat[15] = true;
                }
            }
            if (Halat[16] == false)
            {
                if (pictureBox3.Tag.ToString() == Mohre && pictureBox15.Tag.ToString() == Mohre && pictureBox24.Tag.ToString() == Mohre)
                {
                    X = "031524";
                    Halat[16] = true;
                }
            }
            if (Halat[17] == false)
            {
                if (pictureBox1.Tag.ToString() == Mohre && pictureBox4.Tag.ToString() == Mohre && pictureBox7.Tag.ToString() == Mohre)
                {
                    X = "010407";
                    Halat[17] = true;
                }
            }
            if (Halat[18] == false)
            {
                if (pictureBox3.Tag.ToString() == Mohre && pictureBox6.Tag.ToString() == Mohre && pictureBox9.Tag.ToString() == Mohre)
                {
                    X = "030609";
                    Halat[18] = true;
                }
            }
            if (Halat[19] == false)
            {
                if (pictureBox16.Tag.ToString() == Mohre && pictureBox19.Tag.ToString() == Mohre && pictureBox22.Tag.ToString() == Mohre)
                {
                    X = "161922";
                    Halat[19] = true;
                }
            }
            if (Halat[20] == false)
            {
                if (pictureBox18.Tag.ToString() == Mohre && pictureBox21.Tag.ToString() == Mohre && pictureBox24.Tag.ToString() == Mohre)
                {
                    X = "182124";
                    Halat[20] = true;
                }
            }
                return X;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string Nat,PicName, PicIndex;
            
            PictureBox Pic = (PictureBox)sender;
            if (int.Parse(Mohre1.Text) > 0 || int.Parse(Mohre2.Text) > 0)
            {
                if (Chek == false)
                {
                    if (Pic.Tag.ToString() == "0")
                    {
                        if (Nobat.Text == "1")
                        {
                            Pic.Image = X.Image;
                            Pic.Tag = Nobat.Text;
                            Nat = Xo(Nobat.Text);
                            if (Nat != "000000")
                            {
                                MessageBox.Show("دوز");
                                listBox1.Items.Add(Nat);
                                if (int.Parse(Mohre2.Text) > 0)
                                {
                                    Mohre2.Text = (int.Parse(Mohre2.Text) - 1).ToString();
                                    MessageBox.Show("یک مهره حریف حذف شد");
                                    Tedad2 = Tedad2 - 1;
                                }
                                else
                                {
                                    MessageBox.Show("شما می توانید یک مهره حریف را حذف کنید");
                                    Vaziat = true;
                                    Chek = true;
                                }

                            }
                            Mohre1.Text = (int.Parse(Mohre1.Text) - 1).ToString();
                            Nobat.Text = "2";
                        }
                        else
                        {
                            Pic.Image = O.Image;
                            Pic.Tag = Nobat.Text;
                            Nat = Xo(Nobat.Text);
                            if (Nat != "000000")
                            {
                                MessageBox.Show("دوز");
                                listBox1.Items.Add(Nat);
                                if (int.Parse(Mohre1.Text) > 0)
                                {
                                    Mohre1.Text = (int.Parse(Mohre1.Text) - 1).ToString();
                                    MessageBox.Show("یک مهره حریف حذف شد");
                                    Tedad1 = Tedad1 - 1;
                                }
                                else
                                {
                                    MessageBox.Show("شما می توانید یک مهره حریف را حذف کنید");
                                    Vaziat = true;
                                    Chek = true;
                                }

                            }
                            Mohre2.Text = (int.Parse(Mohre2.Text) - 1).ToString();
                            Nobat.Text = "1";
                        }
                    }
                }
                else
                {
                    if (Nobat.Text == "1")
                    {
                        if (Pic.Tag.ToString() == "2")
                        {
                            Pic.Image = Khali.Image;
                            Pic.Tag = "0";
                            Vaziat = false;
                            Chek = false;
                            Tedad2 = Tedad2 - 1;
                        }
                    }
                    else
                    {
                        if (Pic.Tag.ToString() == "1")
                        {
                            Pic.Image = Khali.Image;
                            Pic.Tag = "0";
                            Vaziat = false;
                            Chek = false;
                            Tedad1 = Tedad1 - 1;
                        }
                    }
 
                }
                if (int.Parse(Mohre1.Text) == 0 && int.Parse(Nobat.Text) == 1)
                    Nobat.Text = "2";
                if (int.Parse(Mohre2.Text) == 0 && int.Parse(Nobat.Text) == 2)
                    Nobat.Text = "1";
            }
            else
            {
                //Game
                if (Vaziat == false)
                {
                    if (label1.Text == "Stop")
                    {
                        if (Pic.Tag.ToString() == Nobat.Text)
                        {
                            PicName = Pic.Name;
                            PicIndex = PicName.Substring(10, PicName.Length - 10);
                            Old = int.Parse(PicIndex);
                            label1.Text = "Move";
                            Pic.Image = Khali.Image;
                            Pic.Tag = 0;
                            TestDoz(Old);
                        }

                    }
                    else
                    {
                        if (Pic.Tag.ToString() == "0")
                        {
                            PicName = Pic.Name;
                            PicIndex = PicName.Substring(10, PicName.Length - 10);
                            Neew = int.Parse(PicIndex);
                                if (Nobat.Text == "1")
                                {
                                    if (Tedad1 > 3)
                                    {
                                        if (TestP(Old, Neew) == true)
                                        {
                                            label1.Text = "Stop";
                                            Pic.Image = X.Image;
                                            Pic.Tag = Nobat.Text;
                                            Nat = Xo(Nobat.Text);
                                            if (Nat != "000000")
                                            {
                                                if (Old != Neew)
                                                {
                                                    MessageBox.Show("دوز");
                                                    listBox1.Items.Add(Nat);
                                                    Vaziat = true;
                                                    MessageBox.Show("شما می توانید یک مهره حریف را حذف کنید");
                                                }
                                            }

                                            Nobat.Text = "2";
                                        }
                                        else
                                            MessageBox.Show("در این خانه نمی توانید مهره بگذارید");
                                    }
                                    else
                                    {
                                        label1.Text = "Stop";
                                        Pic.Image = X.Image;
                                        Pic.Tag = Nobat.Text;
                                        Nat = Xo(Nobat.Text);
                                        if (Nat != "000000")
                                        {
                                            if (Old != Neew)
                                            {
                                                MessageBox.Show("دوز");
                                                listBox1.Items.Add(Nat);
                                                Vaziat = true;
                                                MessageBox.Show("شما می توانید یک مهره حریف را حذف کنید");
                                            }
                                        }

                                        Nobat.Text = "2";

                                    }

                                }
                                else
                                {

                                    if (Tedad2 > 3)
                                    {
                                        if (TestP(Old, Neew) == true)
                                        {
                                            label1.Text = "Stop";
                                            Pic.Image = O.Image;
                                            Pic.Tag = Nobat.Text;
                                            Nat = Xo(Nobat.Text);
                                            if (Nat != "000000")
                                            {
                                                if (Old != Neew)
                                                {
                                                    MessageBox.Show("دوز");
                                                    listBox1.Items.Add(Nat);
                                                    Vaziat = true;
                                                    MessageBox.Show("شما می توانید یک مهره حریف را حذف کنید");
                                                }
                                            }

                                            Nobat.Text = "1";
                                        }
                                        else
                                            MessageBox.Show("در این خانه نمی توانید مهره بگذارید");
                                    }
                                    else
                                    {
                                        label1.Text = "Stop";
                                        Pic.Image = O.Image;
                                        Pic.Tag = Nobat.Text;
                                        Nat = Xo(Nobat.Text);
                                        if (Nat != "000000")
                                        {
                                            if (Old != Neew)
                                            {
                                                MessageBox.Show("دوز");
                                                listBox1.Items.Add(Nat);
                                                Vaziat = true;
                                                MessageBox.Show("شما می توانید یک مهره حریف را حذف کنید");
                                            }
                                        }

                                        Nobat.Text = "1";
                                    }
                                }
                        }
                    }
                }
                else
                {
                    if (Nobat.Text == "1")
                    {
                        if (Pic.Tag.ToString() == "1")
                        {
                            Pic.Image = Khali.Image;
                            Pic.Tag = "0";
                            Vaziat = false;
                            Tedad1 = Tedad1 - 1;
                        }
                    }
                    else
                    {
                        if (Pic.Tag.ToString() == "2") 
                        {
                            Pic.Image = Khali.Image;
                            Pic.Tag = "0";
                            Vaziat = false;
                            Tedad2 = Tedad2 - 1;
                        }
                    }
                }
                if (Tedad1 < 3 || Tedad2 < 3)
                {
                    MessageBox.Show("شما برنده شدید");
                    groupBox1.Enabled = false;
                }
            }
            if (Nobat.Text == "1")
            {
                label4.Visible = true;
                label5.Visible = false;
            }
            else
            {
                if (Nobat.Text == "2")
                {
                    label5.Visible = true;
                    label4.Visible = false;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tedad1 = 6;
            Tedad2 = 6;
            X.Image = Ximage.Image;
            O.Image = Oimage.Image;
            Chek = false;
            Vaziat = false;
            for (int i = 1; i < 25; i++)
            {
                for (int j = 1; j < 7; j++)
                {
                    P[i,j]=0;
                }
            }
                for (int i = 1; i < 21; i++)
                {
                    Halat[i] = false;
                }
            P[1, 1] = 2;      P[1, 2] = 4;         P[1, 3] = 10;         P[1,4]=1;
            P[2, 1] = 1;      P[2, 2] =3;          P[2, 3] = 5;          P[2,4]=2;
            P[3, 1] = 2;      P[3, 2] = 6;         P[3, 3] = 15;         P[3,4]=3;
            P[4, 1] = 1;      P[4, 2] = 5;         P[4, 3] = 7;          P[4, 4] = 11;      P[4,5]=4;
            P[5, 1] = 2;      P[5, 2] = 4;         P[5, 3] = 6;          P[5, 4] = 8;       P[5,5]=5;
            P[6, 1] = 3;      P[6, 2] = 5;         P[6, 3] = 9;          P[6, 4] = 14;      P[6,5]=6;
            P[7, 1] = 4;      P[7, 2] = 8;         P[7, 3] = 12;         P[7,4]=7;
            P[8, 1] = 5;      P[8, 2] = 7;         P[8, 3] = 9;          P[8,4]=8;
            P[9, 1] = 6;      P[9, 2] = 8;         P[9, 3] = 13;         P[9,4]=9;
            P[10, 1] = 1;     P[10, 2] = 11;       P[10, 3] = 22;        P[10,4]=10;
            P[11, 1] = 4;     P[11, 2] = 10;       P[11, 3] = 12;        P[11, 4] = 19;      P[11,5]=11;
            P[12, 1] = 7;     P[12, 2] = 11;       P[12, 3] = 16;        P[12,4]=12;
            P[13, 1] = 9;     P[13, 2] = 14;       P[13, 3] = 18;        P[13,4]=13;
            P[14, 1] = 6;     P[14, 2] = 13;       P[14, 3] = 15;        P[14, 4] = 21;     P[14,5]=14;
            P[15, 1] = 3;     P[15, 2] = 14;       P[15, 3] = 24;        P[15,4]=15;
            P[16, 1] = 12;    P[16, 2] = 17;       P[16, 3] = 19;        P[16, 4] = 16;
            P[17, 1] = 16;    P[17, 2] = 18;       P[17, 3] = 20;        P[17,4]=17;
            P[18, 1] = 13;    P[18, 2] = 17;       P[18, 3] = 21;        P[18,4]=18;
            P[19, 1] = 11;    P[19, 2] = 16;       P[19, 3] = 20;        P[19, 4] = 22;      P[19,5]=19;
            P[20, 1] = 17;    P[20, 2] = 19;       P[20, 3] = 21;        P[20, 4] = 23;      P[20,5]=20;
            P[21, 1] = 14;    P[21, 2] = 18;       P[21, 3] = 20;        P[21, 4] = 24;      P[21,5]=21;
            P[22, 1] = 10;    P[22, 2] = 19;       P[22, 3] = 23;        P[22,4]=22;
            P[23, 1] = 20;    P[23, 2] = 22;       P[23, 3] = 24;        P[23,4]=23;
            P[24, 1] = 15;    P[24, 2] = 21;       P[24, 3] = 23;        P[24,4]=24;
           
        }

        private void بازیجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tedad2 = 6;
            Tedad1 = 6;
            groupBox1.Enabled = true;
            X.Image = Ximage.Image;
            O.Image = Oimage.Image;
            Nobat.Text = "1";
            Mohre1.Text = "6";
            Mohre2.Text = "6";
            label2.Text = "بازیکن یک";
            label3.Text = "بازیکن دو";
            label4.Visible = true;
            label5.Visible = false;
            listBox1.Items.Clear();
            for (int i = 1; i < 21; i++)
            {
                Halat[i] = false;
            }


            pictureBox1.Image = Khali.Image;
            pictureBox1.Tag = 0;
            pictureBox2.Image = Khali.Image;
            pictureBox2.Tag = 0;
            pictureBox3.Image = Khali.Image;
            pictureBox3.Tag = 0;
            pictureBox4.Image = Khali.Image;
            pictureBox4.Tag = 0;
            pictureBox5.Image = Khali.Image;
            pictureBox5.Tag = 0;
            pictureBox6.Image = Khali.Image;
            pictureBox6.Tag = 0;
            pictureBox7.Image = Khali.Image;
            pictureBox7.Tag = 0;
            pictureBox8.Image = Khali.Image;
            pictureBox8.Tag = 0;
            pictureBox9.Image = Khali.Image;
            pictureBox9.Tag = 0;
            pictureBox10.Image = Khali.Image;
            pictureBox10.Tag = 0;
            pictureBox11.Image = Khali.Image;
            pictureBox11.Tag = 0;
            pictureBox12.Image = Khali.Image;
            pictureBox12.Tag = 0;
            pictureBox13.Image = Khali.Image;
            pictureBox13.Tag = 0;
            pictureBox14.Image = Khali.Image;
            pictureBox14.Tag = 0;
            pictureBox15.Image = Khali.Image;
            pictureBox15.Tag = 0;
            pictureBox16.Image = Khali.Image;
            pictureBox16.Tag = 0;
            pictureBox17.Image = Khali.Image;
            pictureBox17.Tag = 0;
            pictureBox18.Image = Khali.Image;
            pictureBox18.Tag = 0;
            pictureBox19.Image = Khali.Image;
            pictureBox19.Tag = 0;
            pictureBox20.Image = Khali.Image;
            pictureBox20.Tag = 0;
            pictureBox21.Image = Khali.Image;
            pictureBox21.Tag = 0;
            pictureBox22.Image = Khali.Image;
            pictureBox22.Tag = 0;
            pictureBox23.Image = Khali.Image;
            pictureBox23.Tag = 0;
            pictureBox24.Image = Khali.Image;
            pictureBox24.Tag = 0;
        }


        private void تعییننوبتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form2();
            Np = "";
            frm.ShowDialog();
            Np = frm.Controls[0].Text;
            Nobat.Text = Np;
            if (Np == "1")
            {
                label4.Visible = true;
                label5.Visible = false;
            }
            if (Np == "2")
            {
                label5.Visible = true;
                label4.Visible = false;
            }

        }
        private void pictureBox25_Click(object sender, EventArgs e)
        {
          
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void انتخابمهرهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void بازیکنیکToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Frm1 = new Form3();
            Frm1.ShowDialog();
            TXt = Frm1.Controls[0].Text;
            if (TXt == "X")
            {
                X.Image = Ximage.Image;
                O.Image = Oimage.Image;
            }
            else
            {
                if (TXt == "O")
                {
                    X.Image = Oimage.Image;
                    O.Image = Ximage.Image;
                }
            }
        }

        private void بازیکندوToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Frm1 = new Form3();
            Frm1.ShowDialog();
            TXt = Frm1.Controls[0].Text;
            if (TXt == "X")
            {
                O.Image = Ximage.Image;
                X.Image = Oimage.Image;
            }
            else
            {
                if (TXt == "O")
                {
                    O.Image = Oimage.Image;
                    X.Image = Ximage.Image;
                }
            }
        }

        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm2 = new Form4();
            frm2.ShowDialog();
            Nam=frm2.Controls[1].Text;
            if (Nam.Length > 0) label2.Text = Nam;

        }

        private void بازیکندوToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm2 = new Form4();
            frm2.ShowDialog();
            Nam = frm2.Controls[1].Text;
            if (Nam.Length > 0) label3.Text = Nam;
        }

        private void ذخیرهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Itm="";
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    Itm += listBox1.Items[i];
                }
                saveFileDialog1.ShowDialog();
            string esm;
            esm=saveFileDialog1.FileName.ToString();
            Zakhire = Esm(label2.Text) + Esm(label3.Text) + Mhr(X) + Mhr(O) + Nobat.Text + Mohre1.Text + Mohre2.Text + savee(groupBox1)+label1.Text+TrueORFalse(Halat)+Itm;
            StreamWriter sw = new StreamWriter(esm+".txt");
            sw.Write(Zakhire);
            sw.Close();
            MessageBox.Show("ذخیره شد");
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string STR,path;
            listBox1.Items.Clear();
            openFileDialog1.ShowDialog();
            path = openFileDialog1.FileName.ToString();
            StreamReader Rd = new StreamReader(path);
            STR = Rd.ReadToEnd();
            Rd.Close();

            
            label2.Text = STR.Substring(0,20);
            label3.Text = STR.Substring(20,20);
             mohreB1 = STR.Substring(40,1);
            if (mohreB1 == "X") X.Image = Ximage.Image;
            if (mohreB1 == "O") X.Image = Oimage.Image;
             mohreB2= STR.Substring(41,1);
            if (mohreB2 == "X") O.Image = Ximage.Image;
            if (mohreB2 == "O") O.Image = Oimage.Image;
            Nobat.Text = STR.Substring(42,1);
            Mohre1.Text = STR.Substring(43,1);
            Mohre2.Text = STR.Substring(44,1);
            Rt = STR.Substring(45,24);
            label1.Text = STR.Substring(69,4);
            SHT = STR.Substring(73,5);
            TrOrFa(SHT);
            int D = STR.Length;
            StrLst = STR.Substring(78,D-78);
            for (int h = 0; h < StrLst.Length; h = h + 6)
            {
                listBox1.Items.Add(StrLst.Substring(h,6));
            }
                if (Nobat.Text == "1")
                {
                    label4.Visible = true;
                    label5.Visible = false;
                }
            if (Nobat.Text == "2")
            {
                label5.Visible = true;
                label4.Visible = false;
            }
            t = 1;
            for (int c = 0; c < 24; c++)
            {
                W = Rt.Substring(c,1);
                for (int a = 1; a < 25; a++)
                {
                    switch(t)
                    {
                        case 1:
                    if (W == "X" || W == "O")
                    {
                        if (W == "X")
                        {
                            pictureBox1.Image = Ximage.Image;
                            if (mohreB1 == "X") pictureBox1.Tag = "1";
                            if (mohreB2 == "X") pictureBox1.Tag = "2";
                        }
                        else
                        {
                                pictureBox1.Image = Oimage.Image;
                                if (mohreB1 == "O") pictureBox1.Tag = "1";
                                if (mohreB2 == "O") pictureBox1.Tag = "2";
                        }
                    }
                    else
                    {
                            pictureBox1.Image = Khali.Image;
                            pictureBox1.Tag = "0";
                    }
                    break;
                        case 2:
                    if (W == "X" || W == "O")
                    {
                        if (W == "X")
                        {
                            pictureBox2.Image = Ximage.Image;
                            if (mohreB1 == "X") pictureBox2.Tag = "1";
                            if (mohreB2 == "X") pictureBox2.Tag = "2";
                        }
                        else
                        {
                                pictureBox2.Image = Oimage.Image;
                                if (mohreB1 == "O") pictureBox2.Tag = "1";
                                if (mohreB2 == "O") pictureBox2.Tag = "2";
                        }
                    }
                    else
                    {
                            pictureBox2.Image = Khali.Image;
                            pictureBox2.Tag = "0";
                    }
                    break;
                        case 3:
                    if (W == "X" || W == "O")
                    {
                        if (W == "X")
                        {
                            pictureBox3.Image = Ximage.Image;
                            if (mohreB1 == "X") pictureBox3.Tag = "1";
                            if (mohreB2 == "X") pictureBox3.Tag = "2";
                        }
                        else
                        {
                            pictureBox3.Image = Oimage.Image;
                            if (mohreB1 == "O") pictureBox3.Tag = "1";
                            if (mohreB2 == "O") pictureBox3.Tag = "2";
                        }
                    }
                    else
                    {
                        pictureBox3.Image = Khali.Image;
                        pictureBox3.Tag = "0";
                    }
                    break;
                        case 4:
                    if (W == "X" || W == "O")
                    {
                        if (W == "X")
                        {
                            pictureBox4.Image = Ximage.Image;
                            if (mohreB1 == "X") pictureBox4.Tag = "1";
                            if (mohreB2 == "X") pictureBox4.Tag = "2";
                        }
                        else
                        {
                            pictureBox4.Image = Oimage.Image;
                            if (mohreB1 == "O") pictureBox4.Tag = "1";
                            if (mohreB2 == "O") pictureBox4.Tag = "2";
                        }
                    }
                    else
                    {
                        pictureBox4.Image = Khali.Image;
                        pictureBox4.Tag = "0";
                    }
                    break;
                        case 5:
                    if (W == "X" || W == "O")
                    {
                        if (W == "X")
                        {
                            pictureBox5.Image = Ximage.Image;
                            if (mohreB1 == "X") pictureBox5.Tag = "1";
                            if (mohreB2 == "X") pictureBox5.Tag = "2";
                        }
                        else
                        {
                            pictureBox5.Image = Oimage.Image;
                            if (mohreB1 == "O") pictureBox5.Tag = "1";
                            if (mohreB2 == "O") pictureBox5.Tag = "2";
                        }
                    }
                    else
                    {
                        pictureBox5.Image = Khali.Image;
                        pictureBox5.Tag = "0";
                    }
                    break;
                        case 6:
                    if (W == "X" || W == "O")
                    {
                        if (W == "X")
                        {
                            pictureBox6.Image = Ximage.Image;
                            if (mohreB1 == "X") pictureBox6.Tag = "1";
                            if (mohreB2 == "X") pictureBox6.Tag = "2";
                        }
                        else
                        {
                            pictureBox6.Image = Oimage.Image;
                            if (mohreB1 == "O") pictureBox6.Tag = "1";
                            if (mohreB2 == "O") pictureBox6.Tag = "2";
                        }
                    }
                    else
                    {
                        pictureBox6.Image = Khali.Image;
                        pictureBox6.Tag = "0";
                    }
                    break;
                        case 7:
                    if (W == "X" || W == "O")
                    {
                        if (W == "X")
                        {
                            pictureBox7.Image = Ximage.Image;
                            if (mohreB1 == "X") pictureBox7.Tag = "1";
                            if (mohreB2 == "X") pictureBox7.Tag = "2";
                        }
                        else
                        {
                            pictureBox7.Image = Oimage.Image;
                            if (mohreB1 == "O") pictureBox7.Tag = "1";
                            if (mohreB2 == "O") pictureBox7.Tag = "2";
                        }
                    }
                    else
                    {
                        pictureBox7.Image = Khali.Image;
                        pictureBox7.Tag = "0";
                    }
                    break;
                        case 8:
                    if (W == "X" || W == "O")
                    {
                        if (W == "X")
                        {
                            pictureBox8.Image = Ximage.Image;
                            if (mohreB1 == "X") pictureBox8.Tag = "1";
                            if (mohreB2 == "X") pictureBox8.Tag = "2";
                        }
                        else
                        {
                            pictureBox8.Image = Oimage.Image;
                            if (mohreB1 == "O") pictureBox8.Tag = "1";
                            if (mohreB2 == "O") pictureBox8.Tag = "2";
                        }
                    }
                    else
                    {
                        pictureBox8.Image = Khali.Image;
                        pictureBox8.Tag = "0";
                    }
                    break;
                        case 9:
                    if (W == "X" || W == "O")
                    {
                        if (W == "X")
                        {
                            pictureBox9.Image = Ximage.Image;
                            if (mohreB1 == "X") pictureBox9.Tag = "1";
                            if (mohreB2 == "X") pictureBox9.Tag = "2";
                        }
                        else
                        {
                            pictureBox9.Image = Oimage.Image;
                            if (mohreB1 == "O") pictureBox9.Tag = "1";
                            if (mohreB2 == "O") pictureBox9.Tag = "2";
                        }
                    }
                    else
                    {
                        pictureBox9.Image = Khali.Image;
                        pictureBox9.Tag = "0";
                    }
                    break;
                        case 10:
                    if (W == "X" || W == "O")
                    {
                        if (W == "X")
                        {
                            pictureBox10.Image = Ximage.Image;
                            if (mohreB1 == "X") pictureBox10.Tag = "1";
                            if (mohreB2 == "X") pictureBox10.Tag = "2";
                        }
                        else
                        {
                            pictureBox10.Image = Oimage.Image;
                            if (mohreB1 == "O") pictureBox10.Tag = "1";
                            if (mohreB2 == "O") pictureBox10.Tag = "2";
                        }
                    }
                    else
                    {
                        pictureBox10.Image = Khali.Image;
                        pictureBox10.Tag = "0";
                    }
                    break;
                        case 11:
                    if (W == "X" || W == "O")
                    {
                        if (W == "X")
                        {
                            pictureBox11.Image = Ximage.Image;
                            if (mohreB1 == "X") pictureBox11.Tag = "1";
                            if (mohreB2 == "X") pictureBox11.Tag = "2";
                        }
                        else
                        {
                            pictureBox11.Image = Oimage.Image;
                            if (mohreB1 == "O") pictureBox11.Tag = "1";
                            if (mohreB2 == "O") pictureBox11.Tag = "2";
                        }
                    }
                    else
                    {
                        pictureBox11.Image = Khali.Image;
                        pictureBox11.Tag = "0";
                    }
                    break;
                        case 12:
                    if (W == "X" || W == "O")
                    {
                        if (W == "X")
                        {
                            pictureBox12.Image = Ximage.Image;
                            if (mohreB1 == "X") pictureBox12.Tag = "1";
                            if (mohreB2 == "X") pictureBox12.Tag = "2";
                        }
                        else
                        {
                            pictureBox12.Image = Oimage.Image;
                            if (mohreB1 == "O") pictureBox12.Tag = "1";
                            if (mohreB2 == "O") pictureBox12.Tag = "2";
                        }
                    }
                    else
                    {
                        pictureBox12.Image = Khali.Image;
                        pictureBox12.Tag = "0";
                    }
                    break;
                        case 13:
                    if (W == "X" || W == "O")
                    {
                        if (W == "X")
                        {
                            pictureBox13.Image = Ximage.Image;
                            if (mohreB1 == "X") pictureBox13.Tag = "1";
                            if (mohreB2 == "X") pictureBox13.Tag = "2";
                        }
                        else
                        {
                            pictureBox13.Image = Oimage.Image;
                            if (mohreB1 == "O") pictureBox13.Tag = "1";
                            if (mohreB2 == "O") pictureBox13.Tag = "2";
                        }
                    }
                    else
                    {
                        pictureBox13.Image = Khali.Image;
                        pictureBox13.Tag = "0";
                    }
                    break;
                        case 14:
                    if (W == "X" || W == "O")
                    {
                        if (W == "X")
                        {
                            pictureBox14.Image = Ximage.Image;
                            if (mohreB1 == "X") pictureBox14.Tag = "1";
                            if (mohreB2 == "X") pictureBox14.Tag = "2";
                        }
                        else
                        {
                            pictureBox14.Image = Oimage.Image;
                            if (mohreB1 == "O") pictureBox14.Tag = "1";
                            if (mohreB2 == "O") pictureBox14.Tag = "2";
                        }
                    }
                    else
                    {
                        pictureBox14.Image = Khali.Image;
                        pictureBox14.Tag = "0";
                    }
                    break;
                        case 15:
                    if (W == "X" || W == "O")
                    {
                        if (W == "X")
                        {
                            pictureBox15.Image = Ximage.Image;
                            if (mohreB1 == "X") pictureBox15.Tag = "1";
                            if (mohreB2 == "X") pictureBox15.Tag = "2";
                        }
                        else
                        {
                            pictureBox15.Image = Oimage.Image;
                            if (mohreB1 == "O") pictureBox15.Tag = "1";
                            if (mohreB2 == "O") pictureBox15.Tag = "2";
                        }
                    }
                    else
                    {
                        pictureBox15.Image = Khali.Image;
                        pictureBox15.Tag = "0";
                    }
                    break;
                        case 16:
                    if (W == "X" || W == "O")
                    {
                        if (W == "X")
                        {
                            pictureBox16.Image = Ximage.Image;
                            if (mohreB1 == "X") pictureBox16.Tag = "1";
                            if (mohreB2 == "X") pictureBox16.Tag = "2";
                        }
                        else
                        {
                            pictureBox16.Image = Oimage.Image;
                            if (mohreB1 == "O") pictureBox16.Tag = "1";
                            if (mohreB2 == "O") pictureBox16.Tag = "2";
                        }
                    }
                    else
                    {
                        pictureBox16.Image = Khali.Image;
                        pictureBox16.Tag = "0";
                    }
                    break;
                        case 17:
                    if (W == "X" || W == "O")
                    {
                        if (W == "X")
                        {
                            pictureBox17.Image = Ximage.Image;
                            if (mohreB1 == "X") pictureBox17.Tag = "1";
                            if (mohreB2 == "X") pictureBox17.Tag = "2";
                        }
                        else
                        {
                            pictureBox17.Image = Oimage.Image;
                            if (mohreB1 == "O") pictureBox17.Tag = "1";
                            if (mohreB2 == "O") pictureBox17.Tag = "2";
                        }
                    }
                    else
                    {
                        pictureBox17.Image = Khali.Image;
                        pictureBox17.Tag = "0";
                    }
                    break;
                        case 18:
                    if (W == "X" || W == "O")
                    {
                        if (W == "X")
                        {
                            pictureBox18.Image = Ximage.Image;
                            if (mohreB1 == "X") pictureBox18.Tag = "1";
                            if (mohreB2 == "X") pictureBox18.Tag = "2";
                        }
                        else
                        {
                            pictureBox18.Image = Oimage.Image;
                            if (mohreB1 == "O") pictureBox18.Tag = "1";
                            if (mohreB2 == "O") pictureBox18.Tag = "2";
                        }
                    }
                    else
                    {
                        pictureBox18.Image = Khali.Image;
                        pictureBox18.Tag = "0";
                    }
                    break;
                        case 19:
                    if (W == "X" || W == "O")
                    {
                        if (W == "X")
                        {
                            pictureBox19.Image = Ximage.Image;
                            if (mohreB1 == "X") pictureBox19.Tag = "1";
                            if (mohreB2 == "X") pictureBox19.Tag = "2";
                        }
                        else
                        {
                            pictureBox19.Image = Oimage.Image;
                            if (mohreB1 == "O") pictureBox19.Tag = "1";
                            if (mohreB2 == "O") pictureBox19.Tag = "2";
                        }
                    }
                    else
                    {
                        pictureBox19.Image = Khali.Image;
                        pictureBox19.Tag = "0";
                    }
                    break;
                        case 20:
                    if (W == "X" || W == "O")
                    {
                        if (W == "X")
                        {
                            pictureBox20.Image = Ximage.Image;
                            if (mohreB1 == "X") pictureBox20.Tag = "1";
                            if (mohreB2 == "X") pictureBox20.Tag = "2";
                        }
                        else
                        {
                            pictureBox20.Image = Oimage.Image;
                            if (mohreB1 == "O") pictureBox20.Tag = "1";
                            if (mohreB2 == "O") pictureBox20.Tag = "2";
                        }
                    }
                    else
                    {
                        pictureBox20.Image = Khali.Image;
                        pictureBox20.Tag = "0";
                    }
                    break;
                        case 21:
                    if (W == "X" || W == "O")
                    {
                        if (W == "X")
                        {
                            pictureBox21.Image = Ximage.Image;
                            if (mohreB1 == "X") pictureBox21.Tag = "1";
                            if (mohreB2 == "X") pictureBox21.Tag = "2";
                        }
                        else
                        {
                            pictureBox21.Image = Oimage.Image;
                            if (mohreB1 == "O") pictureBox21.Tag = "1";
                            if (mohreB2 == "O") pictureBox21.Tag = "2";
                        }
                    }
                    else
                    {
                        pictureBox21.Image = Khali.Image;
                        pictureBox21.Tag = "0";
                    }
                    break;
                        case 22:
                    if (W == "X" || W == "O")
                    {
                        if (W == "X")
                        {
                            pictureBox22.Image = Ximage.Image;
                            if (mohreB1 == "X") pictureBox22.Tag = "1";
                            if (mohreB2 == "X") pictureBox22.Tag = "2";
                        }
                        else
                        {
                            pictureBox22.Image = Oimage.Image;
                            if (mohreB1 == "O") pictureBox22.Tag = "1";
                            if (mohreB2 == "O") pictureBox22.Tag = "2";
                        }
                    }
                    else
                    {
                        pictureBox22.Image = Khali.Image;
                        pictureBox22.Tag = "0";
                    }
                    break;
                        case 23:
                    if (W == "X" || W == "O")
                    {
                        if (W == "X")
                        {
                            pictureBox23.Image = Ximage.Image;
                            if (mohreB1 == "X") pictureBox23.Tag = "1";
                            if (mohreB2 == "X") pictureBox23.Tag = "2";
                        }
                        else
                        {
                            pictureBox23.Image = Oimage.Image;
                            if (mohreB1 == "O") pictureBox23.Tag = "1";
                            if (mohreB2 == "O") pictureBox23.Tag = "2";
                        }
                    }
                    else
                    {
                        pictureBox23.Image = Khali.Image;
                        pictureBox23.Tag = "0";
                    }
                    break;
                        case 24:
                    if (W == "X" || W == "O")
                    {
                        if (W == "X")
                        {
                            pictureBox24.Image = Ximage.Image;
                            if (mohreB1 == "X") pictureBox24.Tag = "1";
                            if (mohreB2 == "X") pictureBox24.Tag = "2";
                        }
                        else
                        {
                            pictureBox24.Image = Oimage.Image;
                            if (mohreB1 == "O") pictureBox24.Tag = "1";
                            if (mohreB2 == "O") pictureBox24.Tag = "2";
                        }
                    }
                    else
                    {
                        pictureBox24.Image = Khali.Image;
                        pictureBox24.Tag = "0";
                    }
                    break;
                }
                    t = t + 1;
                    break;
            }
            }
        }

        private void خروجToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dr =new DialogResult();
            dr = MessageBox.Show("آیا از برنامه خارج می شوید","خروج",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (dr == DialogResult.OK) Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            listBox1.Visible = true;
            newToolStripMenuItem.Enabled = true;
            ذخیرهToolStripMenuItem.Enabled = true;
            خروجToolStripMenuItem.Enabled = true;
            button1.Visible = false;
        }

        
        
        }
}
