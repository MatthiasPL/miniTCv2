using Liczenie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liczenie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string ReplaceAtIndex(int i, char value, string word)
        {
            char[] letters = word.ToCharArray();
            letters[i] = value;
            return string.Join("", letters);
        }

        private static IEnumerable<IEnumerable<T>>
            GetKCombs<T>(IEnumerable<T> list, int length) where T : IComparable
        {
            if (length == 1) return list.Select(t => new T[] { t });
            return GetKCombs(list, length - 1)
                .SelectMany(t => list.Where(o => o.CompareTo(t.Last()) >= 0),
                    (t1, t2) => t1.Concat(new T[] { t2 }));
        }

        private List<double> kwoty = new List<double>();
        private double kwota;
        List<List<double>> listazew = new List<List<double>>();
        private void Zaladuj()
        {
            kwoty = new List<double>();
            kwota = 0;
            string text = textBox1.Text;
            char[] separators = new char[] { ' ', '\n' };
            string[] kwotyText = text.Split(separators);

            foreach (string liczba in kwotyText)
            {
                try
                {
                    if (liczba != "" && liczba!="\n" && liczba!="\r")
                        kwoty.Add(Convert.ToDouble(liczba));
                }
                catch (FormatException)
                {
                    //Console.WriteLine("Unable to convert to a Double.");
                    int id = liczba.IndexOf(".");
                    string temp = ReplaceAtIndex(id, ',', liczba);
                    kwoty.Add(Convert.ToDouble(temp));
                }
                catch (OverflowException)
                {
                    Console.WriteLine("'{0}' is outside the range of a Double.", liczba);
                }
                try
                {
                    if(textBoxKwota.Text!="")
                        kwota = Convert.ToDouble(textBoxKwota.Text);
                }
                catch (FormatException)
                {
                    //Console.WriteLine("Unable to convert to a Double.");
                    int id = textBoxKwota.Text.IndexOf(".");
                    string temp = ReplaceAtIndex(id, ',', textBoxKwota.Text);
                    kwoty.Add(Convert.ToDouble(temp));
                }
                catch (OverflowException)
                {
                    Console.WriteLine("'{0}' is outside the range of a Double.", textBoxKwota.Text);
                }
            }

            //textBoxLiczby.Text = string.Join(" ", kwoty);
        }

        /*private void LiczDlaDwoch()
        {
            for(int i =0; i< kwoty.Count(); i++)
            {
                for( int j=i+1; j<kwoty.Count(); j++)
                {
                    double result = kwoty[i] + kwoty[j];
                    if (result == kwota)
                    {
                        textBoxLiczby.Text = kwoty[i] + Environment.NewLine + kwoty[j];
                        goto End;
                    }
                    else
                    {
                        textBoxLiczby.Text = "brak";
                    }
                }
            }
        End:
            Console.WriteLine("done");
        }
        private void LiczDlaTrzech()
        {
            for(int i =0; i< kwoty.Count(); i++)
            {
                for( int j=i+1; j<kwoty.Count(); j++)
                {
                    for (int k = j + 1; k < kwoty.Count(); k++)
                    {
                        double result = kwoty[i] + kwoty[j] + kwoty[k];
                        if (result == kwota)
                        {
                            textBoxLiczby.Text = kwoty[i] + Environment.NewLine + kwoty[j] + Environment.NewLine + kwoty[k];
                            goto End;
                        }
                        else
                        {
                            textBoxLiczby.Text = "brak";
                        }
                    }
                }
            }
        End:
            Console.WriteLine("done");
        }
        private void LiczDlaCzterech()
        {
        
        }
        */

        private void kombinacje(int n)
        {
            var a = GetKCombs(kwoty.ToList<double>(), n);
            double[] kwity = kwoty.ToArray<double>();

            listazew = new List<List<double>>();
            List<double> listawew = new List<double>();

            int index = 0;

            foreach (var g in a)
            {
                foreach (var b in g)
                {
                    if (index % n != 0 || index == 0)
                        listawew.Add(b);
                    else
                    {
                        listazew.Add(listawew);
                        listawew = new List<double>();
                        listawew.Add(b);
                    }
                    index++;
                }
            }
        }

        private void sprawdz()
        {
            string lancuch = "";

            foreach (var innerlist in listazew)
            {
                double result = innerlist.Sum();
                if (result == kwota)
                {
                    string lancuszek = "";
                    foreach(var liczba in kwoty)
                    {
                        lancuszek += liczba + "   ";
                    }
                    int id = -1;
                    foreach (var liczba in innerlist)
                    {
                        id = lancuszek.IndexOf(liczba.ToString());
                        if (id!=-1)
                        {
                            lancuch += liczba + "   ";
                            lancuszek = lancuszek.Remove(id, liczba.ToString().Length+3);
                        }
                        else
                        {
                            lancuch = "";
                            break;
                        }
                        //Console.WriteLine(lancuszek);
                    }
                    if(lancuch!="")
                        lancuch += Environment.NewLine + "---------------------------" + Environment.NewLine;
                    int liczbalinii=lancuch.Split('\n').Length;
                    if (liczbalinii > 15) break;
                }
                if (textBoxLiczby.Text.IndexOf(lancuch) == -1)
                {
                    textBoxLiczby.Text += lancuch;
                }
                lancuch = "";
            }
        }

        private void buttonLicz_Click(object sender, EventArgs e)
        {
            if (textBoxKwota.Text!="") {
                textBoxLiczby.Text = "";
                Zaladuj();
                Cursor.Current = Cursors.WaitCursor;
                for (int i = 1; i < Convert.ToInt32(comboBoxIle.Text.ToString())+1; i++)
                {
                    kombinacje(i);
                    sprawdz();
                }
                Cursor.Current = Cursors.Default;
            }
            else
            {
                string message = "Podaj kwotę.";
                string caption = "Błąd";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.OK)
                {

                    // Closes the parent form.

                    //this.Close();

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxIle.SelectedIndex=2;
        }
    }
}
