using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Futushki_Game
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            CreateCells();
            StartNewGame();
        }

        Cells[,] Gamecells = new Cells[5, 5];
        SignBox[,] Dusey = new SignBox[4, 5];
        SignBox[,] Yanal = new SignBox[5, 4];

        private void CreateCells()
        {
            #region Oyun içi kutuları konumlandırdık.
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Gamecells[i, j] = new Cells();
                    Gamecells[i, j].Font = new Font(SystemFonts.DefaultFont.FontFamily, 20);
                    Gamecells[i, j].Size = new Size(40, 40);
                    Gamecells[i, j].ForeColor = SystemColors.ControlDark;
                    Gamecells[i, j].Location = new Point(i * 80, j * 80);
                    Gamecells[i, j].FlatStyle = FlatStyle.Flat;
                    Gamecells[i, j].FlatAppearance.BorderColor = Color.Black;
                    Gamecells[i, j].X = i;
                    Gamecells[i, j].Y = j;
                    Gamecells[i, j].KeyPress += Gamecells_KeyPressed;
                    panel1.Controls.Add(Gamecells[i, j]);
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Dusey[i, j] = new SignBox();
                    Dusey[i, j].Font = new Font(SystemFonts.DefaultFont.FontFamily, 20);
                    Dusey[i,j].Size = new Size(40, 40);
                    Dusey[i,j].ForeColor = SystemColors.ControlDark;
                    Dusey[i, j].Enabled = false;

                    Dusey[i, j].Location = new Point((i * 80) + 40, j * 80);
                    Dusey[i, j].X = i;
                    Dusey[i, j].Y = j;
                    panel1.Controls.Add(Dusey[i, j]);
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Yanal[i, j] = new SignBox();
                    Yanal[i, j].Font = new Font(SystemFonts.DefaultFont.FontFamily, 20);
                    Yanal[i, j].Size = new Size(40, 40);
                    Yanal[i, j].ForeColor = SystemColors.ControlDark;
                    Yanal[i, j].Enabled = false;

                    Yanal[i, j].Location = new Point(i*80, (j*80)+40);
                    Yanal[i, j].X = i;
                    Yanal[i, j].Y = j;
                    panel1.Controls.Add(Yanal[i, j]);
                }
            }
            #endregion
        }

        private void Gamecells_KeyPressed(object sender, KeyPressEventArgs e)
        {
            #region Sayı yazdığımız kutuların içerisine 0 ve 5'den büyük değerlerin yazılmamasını sağladık
            var cell = sender as Cells;
            if (cell.IsLocked)
                return;

            int value;
            if (int.TryParse(e.KeyChar.ToString(), out value))
            {
                if (value == 0 || value >5)
                    cell.Clear();
                else
                    cell.Text = value.ToString();

                cell.ForeColor = Color.DodgerBlue;
            }
            #endregion
        }

        private void StartNewGame()
        {
            gameLoad(); //Kutu içlerine değerlerinin atandaığı metod.
            var hintsCount = 9;
            int signCount = 5;

            #region Seviye Seçim İşlemleri
            if (Beginner.Checked)
            {
                hintsCount = 10;
                signCount =5;
            }

            else if(İntermediate.Checked)
            {
                hintsCount = 8;
                signCount = 4;
            }

            else if (Advanced.Checked)
            {
                hintsCount = 6;
                signCount = 4;
            }

            #endregion

            ShowSign(signCount);
            ShowHints(hintsCount);
        }

        #region Oyun içeriğinin oluşturulduğu metot
        private void gameLoad()
        {
            foreach(var cell in Gamecells)
            {
                cell.Value = 0;
                cell.Clear();
            }

            foreach(var duseysign in Dusey)
            {
                duseysign.ClearText();
            }
            foreach (var yatatsign in Yanal)
            {
                yatatsign.ClearText();
            }
            findValueForNextCell(0,-1);
        }
        Random Rnd = new Random();
        private bool findValueForNextCell(int i, int j)
        {
            if(++j > 4)
            {
                j = 0;
                if (++i > 4)
                    return true;

            }

            var value = 0;
            var nums = new List<int> { 1, 2, 3, 4, 5 };

            do
            {
                if (nums.Count < 1)
                {
                    Gamecells[i, j].Value = 0;
                    return false;
                }
                value = nums[Rnd.Next(0, nums.Count)];
                Gamecells[i, j].Value = value;
                nums.Remove(value);
            }
            while (!isValidNumber(value, i, j) || !findValueForNextCell(i, j));
            return true;
        }

        private bool isValidNumber(int value, int x, int y)
        {
            for(int i=0; i<5; i++)
            {
                if (i != y && Gamecells[x, i].Value == value)
                    return false;

                if (i != x && Gamecells[i, y].Value == value)
                    return false;
            }

            return true;
        }
        #endregion

        Random rnd = new Random();
        private void ShowHints (int hintsCount)
        {
            for (int i = 0; i < hintsCount; i++)
            {
                var Random_X = rnd.Next(5);
                var Random_Y = rnd.Next(5);

                Gamecells[Random_X, Random_Y].Text = Gamecells[Random_X, Random_Y].Value.ToString();
                Gamecells[Random_X, Random_Y].ForeColor = Color.Black;
                Gamecells[Random_X, Random_Y].IsLocked = true;

            }
        }
        private void ShowSign(int signCount)
        {
            for (int i = 0; i < signCount; i++)
            {
                var RndDusey_X = rnd.Next(4);
                var RndDusey_Y = rnd.Next(5);

                var RndYatay_X = rnd.Next(5);
                var RndYatay_Y = rnd.Next(4);

                controlMechanDusey(RndDusey_X, RndDusey_Y);
                controlMechanYatay(RndYatay_X, RndYatay_Y);

            }
        }
        #region Küçüktür-büyüktür işaretlerinin yerleşimi
        private void controlMechanDusey(int DuseyX, int DuseyY)
        {
            int leftBoxX = DuseyX;
            int rightBoxX = DuseyX + 1;
            int leftNumber = 0;
            int rightNumber = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if(Gamecells[i,j].X == leftBoxX && Gamecells[i,j].Y == DuseyY)
                    {
                        leftNumber = Gamecells[i, j].Value;
                        break;
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if(Gamecells[i,j].X == rightBoxX && Gamecells[i, j].Y == DuseyY)
                    {
                        rightNumber = Gamecells[i, j].Value;
                        break;
                    }
                }
            }

            if(leftNumber<rightNumber)
            {
                Dusey[DuseyX, DuseyY].Text = "◄";
            }
            else
            {
                Dusey[DuseyX, DuseyY].Text = "►";
            }
        }

        private void controlMechanYatay(int YatayX, int YatayY)
        {
            int downBoxY = YatayY + 1;
            int upperNumber = 0;
            int downNumber = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (Gamecells[i, j].X == YatayX && Gamecells[i, j].Y == YatayY)
                    {
                        upperNumber = Gamecells[i, j].Value;
                        break;

                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (Gamecells[i, j].X == YatayX && Gamecells[i, j].Y == downBoxY)
                    {
                        downNumber = Gamecells[i, j].Value;
                        break;
                    }
                }
            }

            if(upperNumber < downNumber)
                Yanal[YatayX, YatayY].Text = "▲";

            else
                Yanal[YatayX, YatayY].Text = "▼";

        }
        #endregion

        private void CheckInput_Button_Click(object sender, EventArgs e)
        {
            var wrongCells = new List<Cells>();

            foreach (var cell in Gamecells)
            {
                if (!string.Equals(cell.Value.ToString(), cell.Text))
                    wrongCells.Add(cell);
            }
            if(wrongCells.Any())
            {
                wrongCells.ForEach(x => x.ForeColor = Color.Red);
                MessageBox.Show("Wrong Inputs or missing Inputs.");
            }
            else
            {
                DialogResult dr = MessageBox.Show("You finished successfully. , Do you wanna play again", "You Win", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                    StartNewGame();
                else
                    this.Close();
            
            }
        }

        private void NewGame_Button_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void EndGame_Button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Gamecells[i, j].Text = (Gamecells[i, j].Value).ToString();
                }
            }
            DialogResult dr = MessageBox.Show("Sorry , Do you want to exit now?", "Exit", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                this.Close();

            else
                StartNewGame();
        }

        private void ClearInput_Button_Click(object sender, EventArgs e)
        {
            foreach (var cell in Gamecells)
            {
                if (cell.IsLocked == false)
                    cell.Clear();
            }
        }
    }
}
