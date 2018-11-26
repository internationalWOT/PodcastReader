using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logik
{
    public static class Validering
    {
        public static bool textEmpty(string s)
        {
            if (s == "" || s == null)
            {
                return true;

            }
            else
            {
                return false;
            }

        }
        public static bool textFieldNotEmpty(TextBox field, string label)
        {
            if (field.Text == "")
            {
                MessageBox.Show(label + " du måste fylla i något i fältet. fyll därför i något i fältet");
                field.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool listBoxNotEmpty(ListBox lista)
        {
            if (lista.Text == "")
            {
                MessageBox.Show("var vänlig och välj en podcast du vill radera från listan ovan");
                lista.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool comboBoxNotEmpty(ComboBox combo, ListBox lista)
        {
            if (combo.Text == "")
            {
                MessageBox.Show("Var vänlig och välj en ny location på podden i comboboxen ovan");
                combo.Focus();
                return false;
            }
            else if (combo.SelectedItem == lista.SelectedItem)
            {
                MessageBox.Show("podden finns redan i den valda kategorin");
                combo.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool intervalBoxNotEmpty(ComboBox combo)
        {
            if (combo.Text == "")
            {
                MessageBox.Show("var vänlig och välj en uppdateringsintervall");
                combo.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool checkIfValidUrl(string url)
        {
            try
            {
                //Here we are trying to download the file, if it doesn't work, the url is not a valid url.
                var xml = "";
                using (var client = new System.Net.WebClient())
                {
                    client.Encoding = Encoding.UTF8;
                    xml = client.DownloadString(url);
                    return true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("url till podcast är ogiltig, fyll i en giltig url omedelbums!");
                return false;
            }


        }



    }
}
