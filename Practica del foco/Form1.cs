using System;
using System.IO.Ports;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_del_foco
{
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort Arduino;
        //SerialPort serialPort;
        public Form1()
        {
            InitializeComponent();
            Arduino = new System.IO.Ports.SerialPort();
            Arduino = new SerialPort("COM4", 9600); //Asegurese de que el puerto COM sea correcto
            Arduino.Open();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Arduino.Write("F");//Enviar señal para apagar el LED

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Arduino.Write("E");//Enviar señal para encender el LED
        }
    }
}
