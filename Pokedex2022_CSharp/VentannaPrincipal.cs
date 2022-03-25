using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex2022_CSharp
{
    public partial class VentannaPrincipal : Form
    {
        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();
        int idActual = 1; // guarda el id del pokemon que se está mostrando
        public VentannaPrincipal()
        {
            InitializeComponent();
            misPokemons = miConexion.getPokemonPorId(idActual);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            pictureBox1.Image = convierteBlopAImagen((byte[])misPokemons.Rows[0]["imagen"]);
        }

        private Image convierteBlopAImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));

        }

        private void Izquierda_Click(object sender, EventArgs e)
        {
            idActual--;
            if(idActual <= 0) { idActual = 1; }

            misPokemons = miConexion.getPokemonPorId(idActual);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            pictureBox1.Image = convierteBlopAImagen((byte[])misPokemons.Rows[0]["imagen"]);
        }


        private void Derecha_Click(object sender, EventArgs e)
        {
            idActual++;
            if (idActual >= 151) { idActual = 151; }

            misPokemons = miConexion.getPokemonPorId(idActual);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            pictureBox1.Image = convierteBlopAImagen((byte[])misPokemons.Rows[0]["imagen"]);

        }

        private void detalles_Click(object sender, EventArgs e)
        {
            Estadisticas estadisticas = new Estadisticas();
            estadisticas.datosMovimientos(
                misPokemons.Rows[0]["movimiento1"].ToString(),
                misPokemons.Rows[0]["movimiento2"].ToString(),
                misPokemons.Rows[0]["movimiento3"].ToString(),
                misPokemons.Rows[0]["movimiento4"].ToString()
                );
            estadisticas.detallesPokemon(
                misPokemons.Rows[0][   "nombre"].ToString(),
                misPokemons.Rows[0][  "especie"].ToString(),
                misPokemons.Rows[0][   "altura"].ToString(),
                misPokemons.Rows[0][     "peso"].ToString(),
                misPokemons.Rows[0][  "habitat"].ToString(),
                misPokemons.Rows[0][    "tipo1"].ToString(),
                misPokemons.Rows[0][    "tipo2"].ToString(),
                misPokemons.Rows[0]["habilidad"].ToString(),
                misPokemons.Rows[0]["descripcion"].ToString()
                );
            //estadisticas.EspeciePokemon(misPokemons.Rows[0]["especie"].ToString());
            estadisticas.MandaBlop(convierteBlopAImagen((byte[])misPokemons.Rows[0]["imagen"]));
            estadisticas.Show();
        }
    }
}
