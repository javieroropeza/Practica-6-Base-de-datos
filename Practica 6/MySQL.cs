/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 07/05/2014
 * Time: 03:57 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;

namespace Practica_6
{
	/// <summary>
	/// Description of MySQL.
	/// </summary>
	public class MySQL
	{
		public MySqlConnection myConnection;
		public MySQL ()
		{
		}

		public void abrirConexion(){
			string connectionString =
           	"Server=localhost;" +
			"Database=Profesores;" +
			"User ID=root;" +
			"Password=javier;" +
			"Pooling=false;";
			this.myConnection = new MySqlConnection(connectionString);
			this.myConnection.Open();
		}

		public void cerrarConexion(){
			this.myConnection.Close();
			this.myConnection = null;
		}
	}
}
