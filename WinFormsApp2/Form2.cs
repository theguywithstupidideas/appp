using System.Data;
using System.Text.RegularExpressions;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string inp = textBox4.Text;
            int[] numbers = Regex.Matches(inp, @"\d+")
                                    .Cast<Match>()
                                    .Select(m => int.Parse(m.Value))
                                    .ToArray();
            string a = UltiLib.parcheggio(numbers[0]).ToString();
            string inputt = "Risultato:  ";
            string[] words = inputt.Split(new string[] { ": " }, StringSplitOptions.None);
            words[1] = a + "€";
            string output = string.Join(": ", words);
            label7.Text = output;
        }
    }
}
