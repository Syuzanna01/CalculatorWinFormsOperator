namespace CalculatorWinFormsOperator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2;
            char sign;
            string str, n1 = null, n2 = null;
            str = Box1.Text;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '+' | str[i] == '-' | str[i] == '*' | str[i] == '/')
                {
                    bool isParsable1 = Int32.TryParse(n1, out _);
                    if (isParsable1)
                    {
                        sign = str[i];
                        num1 = Int32.Parse(n1);
                        for (int j = i + 1; j < str.Length + 1; j++)
                        {
                            if (j == str.Length)
                            {
                                bool isParsable2 = Int32.TryParse(n2, out _);
                                if (isParsable2)
                                {
                                    num2 = Int32.Parse(n2);

                                    Calculator num11 = new Calculator(num1);
                                    Calculator num22 = new Calculator(num2);
                                    Calculator num3 = new Calculator();

                                    switch (sign)
                                    {
                                        case '+':
                                            num3 = num11 + num22;
                                            
                                            break;
                                        case '-':
                                            num3 = num11 - num22;
                                            break;
                                        case '*':
                                            num3 = num11 * num22;
                                            break;
                                        case '/':
                                            num3 = num11 / num22;
                                            break;
                                    }
                                    Box1.Text =Convert.ToString(num3.display());
                                    break;
                                }
                                else
                                {
                                    Box1.Text = "error";
                                    break;
                                }
                            }
                            n2 += str[j];
                        }
                        break;
                    }
                    else
                        Box1.Text = "error";
                }
                n1 += str[i];
            }
        }
    }
}