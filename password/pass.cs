using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password
{
    public partial class pass : Form
    {
        public static char[] passiner = new char[] { };
        public static List<char> reqemm = new List<char>() { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        public static List<char> boyuk = new List<char>() {'Q','W','E','R','T','Y','U','I','O','P', 'A','S','D','F','G', 'H', 'J', 'K','L','Z','X','C','V','B','N','M' };
        public static List<char> simvoll= new List<char>() {'!','@','#','$','%','^','&','*','(',')','_','-','=','+','/','|',']','[','{','}','"',';',':','>','.','<',',','?','~' };
        public static List<char> kicik = new List<char>() { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm' };

        public static string st;
        public pass()
        {
            InitializeComponent();
        }

        private void passwordd_TextChanged(object sender, EventArgs e)
        {
            st = passwordd.Text;
            char[] passiner = st.ToCharArray();
            reqem.BackColor = Color.White;
            boyukherif.BackColor = Color.White;
            simvol.BackColor = Color.White;
            kicikherif.BackColor = Color.White;
            minimum8.BackColor = Color.White;

            foreach (var req in reqemm)
            {
                
                for (int i = 0; i < passiner.Length; i++)
                {
                    if (req==passiner[i])
                    {
                        reqem.BackColor = Color.Red;
                        break;
                    }
                }
            }
            foreach (var boy in boyuk)
            {

                for (int i = 0; i < passiner.Length; i++)
                {
                    if (boy == passiner[i])
                    {
                        boyukherif.BackColor = Color.Red;
                        break;
                    }
                }
            }
            foreach (var sim in simvoll)
            {

                for (int i = 0; i < passiner.Length; i++)
                {
                    if (sim == passiner[i])
                    {
                        simvol.BackColor = Color.Red;
                        break;
                    }
                }
            }
            foreach (var sim in kicik)
            {

                for (int i = 0; i < passiner.Length; i++)
                {
                    if (sim == passiner[i])
                    {
                        kicikherif.BackColor = Color.Red;
                        break;
                    }
                }
            }
            if (passiner.Length > 7)
            {
                minimum8.BackColor = Color.Red;
            }
        }
    }
}
