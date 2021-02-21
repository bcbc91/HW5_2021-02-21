using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CircumferenceAndArea.Concrete;

namespace CircumferenceAndArea
{
    public partial class Form1 : Form
    {
        string[] _shapes = new string[5] { "Daire", "Eşkenar Üçgen", "Dik Üçgen", "Kare", "Dikdörtgen" };
        private Circle circle = new Circle();
        private Square square = new Square();
        private Rectangular rectangular = new Rectangular();
        private EquilateralTriangle equilateralTriangle = new EquilateralTriangle();
        private RightTriangle rightTriangle = new RightTriangle();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ddlShape.Items.AddRange(_shapes);
            ddlShape.Text = "";



        }
        private void ddlShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlShape.SelectedIndex == 0)
            {
                tbHeight.Enabled = false;
                tbLongEdge.Enabled = false;
                tbShortEdge.Enabled = false;
                tbBottomEdge.Enabled = false;
            }

            if (ddlShape.SelectedIndex == 1)
            {
                tbHeight.Enabled = false;
                tbLongEdge.Enabled = false;
                tbShortEdge.Enabled = false;
                tbRadius.Enabled = false;
            }

            if (ddlShape.SelectedIndex == 2)
            {

                tbLongEdge.Enabled = false;
                tbShortEdge.Enabled = false;
                tbRadius.Enabled = false;
            }

            if (ddlShape.SelectedIndex == 3)
            {
                tbHeight.Enabled = false;
                tbBottomEdge.Enabled = false;
                tbShortEdge.Enabled = false;
                tbRadius.Enabled = false;
            }

            if (ddlShape.SelectedIndex == 4)
            {
                tbHeight.Enabled = false;
                tbBottomEdge.Enabled = false;

                tbRadius.Enabled = false;
            }
        }
        private void bCalculate_Click(object sender, EventArgs e)
        {
            double check;
            if (ddlShape.SelectedIndex==0)
            {
                
                if (string.IsNullOrWhiteSpace(tbRadius.Text)|| !double.TryParse(tbRadius.Text.Trim(), out check))
                {
                    MessageBox.Show("Lütfen Sayı Giriniz!!", "Hata!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    circle.Radius = Convert.ToDouble(tbRadius.Text);
                    double Area = circle.CalculateArea();
                    tbArea.Text = Area.ToString();

                    double Circumference = circle.CalculateCircumference();
                    tbCircumference.Text = Circumference.ToString();

                }

            }

            if (ddlShape.SelectedIndex==1)
            {
                if (string.IsNullOrWhiteSpace(tbBottomEdge.Text) || !double.TryParse(tbBottomEdge.Text.Trim(), out check))
                {
                    MessageBox.Show("Lütfen Sayı Giriniz!!", "Hata!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    equilateralTriangle.BottomEdge = Convert.ToDouble(tbBottomEdge.Text);
                    double Area = equilateralTriangle.CalculateArea();
                    tbArea.Text = Area.ToString();

                    double Circumference = equilateralTriangle.CalculateCircumference();
                    tbCircumference.Text = Circumference.ToString();
                }

               
            }

            if (ddlShape.SelectedIndex==2)
            {
                if (string.IsNullOrWhiteSpace(tbBottomEdge.Text) || !double.TryParse(tbBottomEdge.Text.Trim(), out check))
                {
                    MessageBox.Show("Lütfen Sayı Giriniz!!", "Hata!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                if (string.IsNullOrWhiteSpace(tbHeight.Text) || !double.TryParse(tbHeight.Text.Trim(), out check))
                {
                    MessageBox.Show("Lütfen Sayı Giriniz!!", "Hata!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    rightTriangle.BottomEdge = Convert.ToDouble(tbBottomEdge.Text);
                    rightTriangle.Height = Convert.ToDouble(tbHeight.Text);
                    double Area = rightTriangle.CalculateArea();
                    tbArea.Text = Area.ToString();

                    double Circumference = rightTriangle.CalculateCircumference();
                    tbCircumference.Text = Circumference.ToString();
                }

               

               
            }

            if (ddlShape.SelectedIndex==3)
            {
                if (string.IsNullOrWhiteSpace(tbLongEdge.Text) || !double.TryParse(tbLongEdge.Text.Trim(), out check))
                {
                    MessageBox.Show("Lütfen Sayı Giriniz!!", "Hata!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    square.LongEdge = Convert.ToDouble(tbLongEdge.Text);
                    double Area = square.CalculateArea();
                    tbArea.Text = Area.ToString();

                    double Circumference = square.CalculateCircumference();
                    tbCircumference.Text = Circumference.ToString();
                }
                
            }

            if (ddlShape.SelectedIndex==4)
            {
                if (string.IsNullOrWhiteSpace(tbLongEdge.Text) || !double.TryParse(tbLongEdge.Text.Trim(), out check))
                {
                    MessageBox.Show("Lütfen Sayı Giriniz!!", "Hata!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                if (string.IsNullOrWhiteSpace(tbShortEdge.Text) || !double.TryParse(tbShortEdge.Text.Trim(), out check))
                {
                    MessageBox.Show("Lütfen Sayı Giriniz!!", "Hata!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    rectangular.LongEdge = Convert.ToDouble(tbLongEdge.Text);
                    rectangular.ShortEdge = Convert.ToDouble(tbShortEdge.Text);
                    double Area = rectangular.CalculateArea();
                    tbArea.Text = Area.ToString();

                    double Circumference = rectangular.CalculateCircumference();
                    tbCircumference.Text = Circumference.ToString();
                }
               
            }

           
        }

        private void bClear_Click(object sender, EventArgs e)
        {

            tbShortEdge.Text = "";
            tbArea.Text = "";
            tbCircumference.Text = "";
            tbHeight.Text = "";
            tbBottomEdge.Text = "";
            tbHeight.Text = "";
            tbLongEdge.Text = "";
            tbRadius.Text = "";
            ddlShape.SelectedItem = null;
            tbRadius.Enabled = true;
            tbHeight.Enabled = true;
            tbShortEdge.Enabled = true;
            tbBottomEdge.Enabled = true;
            tbLongEdge.Enabled = true;
        }
    }
}
