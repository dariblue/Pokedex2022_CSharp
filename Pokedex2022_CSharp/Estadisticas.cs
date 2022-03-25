using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex2022_CSharp
{
    public partial class Estadisticas : Form
    {

        public String nombrePokemon;

        public Estadisticas()
        {
            InitializeComponent();
            label1.Text = nombrePokemon;
        }

        public void datosMovimientos(String movimiento1, String movimiento2, String movimiento3, String movimiento4)
        {

            if(movimiento2 == "")
            {
                label2.Text = "Movimiento: " + movimiento1;
            }
            if (movimiento3 == "")
            {
                label2.Text =
                   "Movimientos:" +
                   "\nMovimiento 1: " + movimiento1 +
                   "\nMovimiento 2: " + movimiento2;
            }
            if (movimiento4 == "")
            {
                label2.Text =
                    "Movimientos:" +
                    "\nMovimiento 1: " + movimiento1 +
                    "\nMovimiento 2: " + movimiento2 +
                    "\nMovimiento 3: " + movimiento3;
            }
            else
            {
                label2.Text =
                     "Movimientos:" +
                     "\nMovimiento 1: " + movimiento1 +
                     "\nMovimiento 2: " + movimiento2 +
                     "\nMovimiento 3: " + movimiento3 +
                     "\nMovimiento 4: " + movimiento4;
            }
            
        }

        public void detallesPokemon(String nombrePokemon, String especie, String altura, String peso, String habitat, String tipo1, String tipo2, String habilidad, String descripcion)
        {
            if (tipo2 == "")
            {
                label1.Text = nombrePokemon;
                label3.Text =
                    "Altura: " + altura +
                    "\nPeso: " + peso +
                    "\nEspecie: " + especie +
                    "\nSu habitat es: " + habitat +
                    "\nSu tipo es: " + tipo1 +
                    "\nSu habilidad es: " + habilidad
                ;

            }
            else
            {
                label1.Text = nombrePokemon;
                label3.Text =
                    "Altura: " + altura +
                    "\nPeso: " + peso +
                    "\nEspecie: " + especie +
                    "\nSu habitat es: " + habitat +
                    "\nSus tipos son: " + tipo1 + ", " + tipo2 +
                    "\nSu habilidad es: " + habilidad +
                    "\n" + descripcion
                    ;
            }
            

        }


        public void MandaBlop(Image image)
        {
            pictureBox1.Image = image;
        }
    }
}
