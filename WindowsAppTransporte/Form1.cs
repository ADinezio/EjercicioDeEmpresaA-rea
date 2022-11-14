using LibreriaTransportes.Model.Derivadas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsAppTransporte
{
    public partial class Form1 : Form
    {
        Jet jet;
        Helicoptero helicoptero;
        List<Azafata> azafatas=new List<Azafata>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearInstancias_Click(object sender, EventArgs e)
        {
            azafatas.Add(new Azafata("Maria", "Gomez"));
            azafatas.Add(new Azafata("Gomez", "Maria"));
            azafatas.Add(new Azafata("Martina", "Perez"));

            jet = new Jet(5, 800, 12000,new Piloto("Pepe","grillo"),new Copiloto("Matias","Tito"),azafatas);
            helicoptero = new Helicoptero(3, 200, 8000, 4,new Piloto("Agustin","Di Nezio"),new Copiloto("Ana","Perez"));
            
        }


        private void btnMostrarJet_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jet.datosTripulacion());
            MessageBox.Show(jet.aterrizar("pista"));
            MessageBox.Show(jet.despegar("pista"));
            MessageBox.Show(jet.mantenimiento());
            MessageBox.Show(jet.msj());
        }

        private void btnHelicoptero_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Nombre Piloto : {helicoptero.Piloto.Nombre}\nApellido : {helicoptero.Piloto.Apellido}");
            MessageBox.Show($"Nombre Copiloto : {helicoptero.Copiloto.Nombre}\nApellido : {helicoptero.Copiloto.Apellido}");
            MessageBox.Show(helicoptero.aterrizar());
            MessageBox.Show(helicoptero.despegar());
            MessageBox.Show(helicoptero.msj());
        }
    }
}
