using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon;
    internal class Repo
    {
        /// <summary>
        /// Método para Obtener los pokemons
        /// </summary>
        /// <returns></returns>
        public static DataSet ObtenerPokemons()
        {
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter();

            try
            {
                comando.CommandText = "SELECT * FROM POKEMONS";
                comando.Connection = conexion.cnx;
                adaptador.SelectCommand = comando;
                conexion.cnx.Open();
                adaptador.Fill(ds);
                conexion.cnx.Close();

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ds;
        }

        /// <summary>
        /// Método para crear un pokemon.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool CrearPokemon(Pokemon p)
        {
            bool todoCorrecto = false;
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();

            try
            { 
                comando.CommandText = "set dateformat dmy; INSERT INTO POKEMONS VALUES ('" + p.nombre + "', '" + p.fechaCreacion + "', '" + p.puntosVida + "', '" + p.puntosAtaque + "', '" + p.puntosDefensa + "', '" + p.tipo + "', '" + p.descripcion + "')";

                comando.Connection = conexion.cnx;
                conexion.cnx.Open();
                comando.ExecuteNonQuery();
                conexion.cnx.Close();

                todoCorrecto = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                todoCorrecto = false;
            }

            return todoCorrecto;
        }

        /// <summary>
        /// Método para eliminar un pokemon.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool EliminarPokemon(Pokemon p)
        {
            bool todoCorrecto = false;
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.CommandText = "DELETE FROM POKEMONS WHERE ID = '" + p.Id + "'";

                comando.Connection = conexion.cnx;
                conexion.cnx.Open();
                comando.ExecuteNonQuery();
                conexion.cnx.Close();

                todoCorrecto = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                todoCorrecto = false;
            }

            return todoCorrecto;
        }

        /// <summary>
        /// Método para modificar un pokemon.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool ModificarPokemon(Pokemon p)
        {
            bool todoCorrecto = false;
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.CommandText = "set dateformat dmy; UPDATE POKEMONS SET NOMBRE = '" + p.nombre + "', FECHACREACION= '" + p.fechaCreacion + "', " +
                    "PUNTOSVIDA = '" + p.puntosVida + "', PUNTOSATAQUE= '" + p.puntosAtaque + "', PUNTOSDEFENSA= '" + p.puntosDefensa + "' "+", TIPO= '" + p.tipo  + "', DESCRIPCION= '" + p.descripcion + "' "+
                    " WHERE ID = '" + p.Id + "'";

                comando.Connection = conexion.cnx;
                conexion.cnx.Open();
                comando.ExecuteNonQuery();
                conexion.cnx.Close();

                todoCorrecto = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                todoCorrecto = false;
            }

            return todoCorrecto;
        }
    }
