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

namespace Шифр_Цезаря
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] alphabet =
        {"А","Б","В","Г","Д","Е","Ё","Ж","З","И","Й","К","Л","М","Н","О","П","Р","С","Т","У","Ф","Х","Ц","Ч","Ш","Щ","Ъ","Ы","Ь","Э","Ю","Я"};
        
    
        private void button1_Click(object sender, EventArgs e)
        {
            //запись каждой буквы в лист для последущей шифровки
            List<string> output = new List<string>();
            int n = Convert.ToInt32(textBox3.Text);
            n = n % alphabet.Length;
            textBox2.Clear();
            List<string> abc = new List<string>();
            int alphCount = 0;

            for (int i = 0; i < textBox1.Text.Length; i++) 
            {
                abc.Add("");
                abc[i] += textBox1.Text[i];
                abc[i] = abc[i].ToUpper();
            }
            

            //нахождение буквы
            for (int i = 0; i < abc.Count; i++)
            {
                int pos = 0;

                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (alphabet[j] == abc[i])
                    {
                        pos = j; break;
                    }
                }

                
                alphCount = pos + n;
                if(alphCount > alphabet.Length)
                {
                    alphCount = alphCount % alphabet.Length;
                }
                output.Add(alphabet[alphCount]);               
            }
            for(int i = 0;i < output.Count;i++) 
            {
                textBox2.Text += output[i];
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //запись каждой буквы в лист для последущей шифровки
            List<string> output = new List<string>();
            int n = Convert.ToInt32(textBox3.Text);
            n = n % alphabet.Length;
            textBox2.Clear();
            List<string> abc = new List<string>();
            int alphCount = 0;

            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                abc.Add("");
                abc[i] += textBox1.Text[i];
                abc[i] = abc[i].ToUpper();
            }

            for (int i = 0; i < abc.Count; i++)
            {
                int pos = 0;

                //нахождение букв в массиве
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (alphabet[j] == abc[i])
                    {
                        pos = j; break;
                    }
                }

                
                alphCount = pos - n;
                if (alphCount < 0)
                {
                    alphCount = alphCount + alphabet.Length-1;
                }
                output.Add(alphabet[alphCount]);
            }
            for (int i = 0; i < output.Count; i++)
            {
                textBox2.Text += output[i];
            }
        }
    }
}
