using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //运算参数
        string x;
        string y;

        //判断那个运算符
        bool isAdd = false;
        bool isSub = false;
        bool isMul = false;
        bool isDiv = false;
        bool isOperator = false;
        bool isClear = false;

        //是否多操作符
        bool operatorRepetition = false;

        //结果
        double result = 0;

        //数字键
        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            this.OutPutText.Text += "0";
            this.CalculateText.Text += "0";

            if(!isOperator)
                x = this.CalculateText.Text;
            else
                y = this.CalculateText.Text;
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            this.OutPutText.Text += "1";
            this.CalculateText.Text += "1";

            if (!isOperator)
                x = this.CalculateText.Text;
            else
                y = this.CalculateText.Text;
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            this.OutPutText.Text += "2";
            this.CalculateText.Text += "2";

            if (!isOperator)
                x = this.CalculateText.Text;
            else
                y = this.CalculateText.Text;
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            this.OutPutText.Text += "3";
            this.CalculateText.Text += "3";

            if (!isOperator)
                x = this.CalculateText.Text;
            else
                y = this.CalculateText.Text;
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            this.OutPutText.Text += "4";
            this.CalculateText.Text += "4";

            if (!isOperator)
                x = this.CalculateText.Text;
            else
                y = this.CalculateText.Text;
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            this.OutPutText.Text += "5";
            this.CalculateText.Text += "5";

            if (!isOperator)
                x = this.CalculateText.Text;
            else
                y = this.CalculateText.Text;
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            this.OutPutText.Text += "6";
            this.CalculateText.Text += "6";

            if (!isOperator)
                x = this.CalculateText.Text;
            else
                y = this.CalculateText.Text;
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            this.OutPutText.Text += "7";
            this.CalculateText.Text += "7";

            if (!isOperator)
                x = this.CalculateText.Text;
            else
                y = this.CalculateText.Text;
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            this.OutPutText.Text += "8";
            this.CalculateText.Text += "8";

            if (!isOperator)
                x = this.CalculateText.Text;
            else
                y = this.CalculateText.Text;
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            this.OutPutText.Text += "9";
            this.CalculateText.Text += "9";

            if (!isOperator)
                x = this.CalculateText.Text;
            else
                y = this.CalculateText.Text;
        }   


        //符号键
        private void Dot_Click(object sender, RoutedEventArgs e)
        {
            this.OutPutText.Text += ".";
            this.CalculateText.Text += ".";
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {

            if (isOperator)
            {
                this.OutPutText.Text += "=";
                this.CalculateText.Text += "";

                if (isAdd)
                {
                    result = CalculatorMethods.Add(Double.Parse(x), Double.Parse(y));
                }
                else if (isSub)
                {
                    result = CalculatorMethods.Sub(Double.Parse(x), Double.Parse(y));
                }
                else if (isMul)
                {
                    result = CalculatorMethods.Mul(Double.Parse(x), Double.Parse(y));
                }
                else
                {
                    result = CalculatorMethods.Div(Double.Parse(x), Double.Parse(y));
                }

                //赋值和进行下一次计算
                this.OutPutText.Text += result.ToString();
                this.CalculateText.Text = result.ToString();
                x = result.ToString();
            }


            //重置
            isAdd = false;
            isSub = false;
            isMul = false;
            isDiv = false;
            isOperator = false;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            this.OutPutText.Text += "+";

            this.CalculateText.Text = "";

            isAdd = true;
            isOperator = true;

        }

        private void Sub_Click(object sender, RoutedEventArgs e)
        {
            this.OutPutText.Text += "-";

            this.CalculateText.Text = "";

            isSub = true;
            isOperator = true;

        }

        private void Mul_Click(object sender, RoutedEventArgs e)
        {
            this.OutPutText.Text += "*";

            this.CalculateText.Text = "";

            isMul = true;
            isOperator = true;

        }

        private void Div_Click(object sender, RoutedEventArgs e)
        {
            this.OutPutText.Text += "÷";

            this.CalculateText.Text = "";

            isDiv = true;
            isOperator = true;

        }

        //功能键
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            this.CalculateText.Text = "";
            this.OutPutText.Text = "";
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(this.CalculateText.Text))
            {
                this.CalculateText.Text = this.CalculateText.Text.Substring(0, this.CalculateText.Text.Length - 1);
                this.OutPutText.Text = this.OutPutText.Text.Substring(0, this.OutPutText.Text.Length - 1);
            }
        }
    }
}
