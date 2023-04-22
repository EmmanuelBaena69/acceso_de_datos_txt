using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace acceso_de_datos_txt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            using (var fileStream = new FileStream("archivo.txt", FileMode.Append))
            {
                using (var streamWriter = new StreamWriter(fileStream))
                {
                    streamWriter.WriteLine("Emmanuel Baena");
                    streamWriter.WriteLine("lisa Monoban");
                    streamWriter.Close();

                    MessageBox.Show("Listo");
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (File.Exists("archivo.txt"))
            {
                File.Delete("archivo.txt");
                Console.WriteLine("El archivo se elimio");
            }
            else
            {
                Console.WriteLine("El archivo no existe");
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            TextReader Leer = new StreamReader("archivo.txt");
            MessageBox.Show(Leer.ReadToEnd());

            Leer.Close();
        }
    }
}
