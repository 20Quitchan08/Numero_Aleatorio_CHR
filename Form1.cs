using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numero_Aleatorio_CHR
{
    public partial class Form1 : Form
    {
        int intentos = 0;//iniciarlizar la variable intentos
        Random rand = new Random();
        int Aleatorio = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int intentos = 5; // Cantidad de intentos
            txtintentos.Text = intentos.ToString();
            Aleatorio = rand.Next(1, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtnumero.Text, out int num) && num > 0)
            {
                if (num == Aleatorio)
                {
                    MessageBox.Show($"Ganó el juego, el número es {Aleatorio} ");
                    DialogResult resultado = MessageBox.Show("¿Quisieras volver a jugar?", "Reintentar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.No)
                    {
                        MessageBox.Show("Gracias por jugar :)");
                        Application.Exit();
                    }
                    else
                    {
                        intentos = 5;
                        txtintentos.Text = intentos.ToString();
                        Aleatorio = rand.Next(1, 100);
                    }
                }
                if (num > Aleatorio)
                {
                    MessageBox.Show($"{num} es mayor al número");
                    intentos = intentos - 1;
                    txtintentos.Text = intentos.ToString();
                }
                if (num < Aleatorio)
                {
                    MessageBox.Show($"{num} es menor al número");
                }
                if (intentos == 0 )
                {
                    DialogResult resultado = MessageBox.Show("Se acabaron los intentos :(. ¿Quieres volver a intentarlo?", MessageBoxButtons.YesNo, MessageBoxIcon.stop);
                }
                if (resultado == DialogResult.No)
                {
                    MessageBox.Show("Suerte para la proxima");
                    Application.Exit();
                }
                    
                }
                else
                {
                    intentos = 5;
                    txtintentos.Text = intentos.ToString();
                    Aleatorio = rand.Next(1, 100);
                }
            }
            else
            {
                MessageBox.Show("ingrese un numero valido :)");
            }
        }
    }
}
