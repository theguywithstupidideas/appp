using System.Text.RegularExpressions;
namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        bool f = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inp = textBox1.Text;
            string input = inp;
            int[] numbers = Regex.Matches(input, @"\d+")
                                    .Cast<Match>()
                                    .Select(m => int.Parse(m.Value))
                                    .ToArray();
            float[] numberss = Regex.Matches(input, @"\d+")
                                    .Cast<Match>()
                                    .Select(m => float.Parse(m.Value))
                                    .ToArray();
            float a;
            int c;
            string b = "";
            if (f == true)
            {
                a = UltiLib.medf(numberss[0], numberss[1], numberss[2]);
                b = a.ToString();
            }
            else
            {
                c = UltiLib.med(numbers[0], numbers[1], numbers[2]);
                b = c.ToString();
            }
            string inputt = "Risultato:  ";
            string[] words = inputt.Split(new string[] { ": " }, StringSplitOptions.None);
            words[1] = b;
            string output = string.Join(": ", words);
            label2.Text = output;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            f = !(f);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string inp = textBox2.Text;
            int[] numbers = Regex.Matches(inp, @"\d+")
                                    .Cast<Match>()
                                    .Select(m => int.Parse(m.Value))
                                    .ToArray();
            string a = UltiLib.Op(numbers[0], numbers[1]);
            string str = String.Join(" ", a);
            string inputt = "Risultato:  ";
            string[] words = inputt.Split(new string[] { ": " }, StringSplitOptions.None);
            words[1] = str;
            string output = string.Join(": ", words);
            label4.Text = output;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string inp = textBox3.Text;
            int[] numbers = Regex.Matches(inp, @"\d+")
                                    .Cast<Match>()
                                    .Select(m => int.Parse(m.Value))
                                    .ToArray();
            string a = UltiLib.arr(numbers[0]).ToString();
            string inputt = "Risultato:  ";
            string[] words = inputt.Split(new string[] { ": " }, StringSplitOptions.None);
            words[1] = a;
            string output = string.Join(": ", words);
            label6.Text = output;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string inp = textBox4.Text;
            int[] numbers = Regex.Matches(inp, @"\d+")
                                    .Cast<Match>()
                                    .Select(m => int.Parse(m.Value))
                                    .ToArray();
            string a = UltiLib.Sw(numbers[0], numbers[1]);
            string inputt = "Risultato:  ";
            string[] words = inputt.Split(new string[] { ": " }, StringSplitOptions.None);
            words[1] = a;
            string output = string.Join(": ", words);
            label7.Text = output;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string inp = textBox5.Text;
            int[] numbers = Regex.Matches(inp, @"\d+")
                                    .Cast<Match>()
                                    .Select(m => int.Parse(m.Value))
                                    .ToArray();
            string a = UltiLib.Ps(numbers[0]);
            string inputt = "Risultato:  ";
            string[] words = inputt.Split(new string[] { ": " }, StringSplitOptions.None);
            words[1] = a;
            string output = string.Join(": ", words);
            label9.Text = output;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string inp = textBox6.Text;
            string input = inp;
            int[] numbers = Regex.Matches(input, @"\d+")
                                    .Cast<Match>()
                                    .Select(m => int.Parse(m.Value))
                                    .ToArray();
            string a = UltiLib.quad(numbers[0]).ToString();
            string inputt = "Risultato:  ";
            string[] words = inputt.Split(new string[] { ": " }, StringSplitOptions.None);
            words[1] = a;
            string output = string.Join(": ", words);
            label11.Text = output;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}