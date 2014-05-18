/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 07/05/2014
 * Time: 03:40 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;

namespace Practica_6
{
	class Program
	{
		public static void Main(string[] args)
		{
			int pal = 5;
			do{
				Console.WriteLine("\t***Menu***\n");
				Console.WriteLine("1) Ver\n");
            			Console.WriteLine("2) Agregar \n");
				Console.WriteLine("3) Editar\n");
 				Console.WriteLine("4) Eliminar\n");
 				Console.WriteLine("5) Salir\n");
			
 				pal = int.Parse( Console.ReadLine() );
 				Profesorescs profesor = new Profesorescs();
 				switch( pal ){
 					case 1:
						profesor.mostrarTodos();
						break;	
						
					case 2:
						Console.WriteLine( "Dame el ID " );
						String id = Console.ReadLine();
						Console.WriteLine( "Dame el codigo " );
						String codigo = Console.ReadLine();
						Console.WriteLine( "Dame el nombre" );
						String nombre = Console.ReadLine();
						profesor.insertarRegistroNuevo(id, codigo,  nombre);
						
						break;

					case 3:

						Console.WriteLine( "Dame el  ID del registro" );
						  id = Console.ReadLine();
						
						 
						if(profesor.Buscarid( id )){
							Console.WriteLine( " codigo " );
							Console.WriteLine( " nombre" );
							Console.WriteLine("¿Seguro que desea editarlo?" );
							string dig = Console.ReadLine();
							if(dig == "s"){
								Console.WriteLine( "Dame el codigo " );
								codigo = Console.ReadLine();
								Console.WriteLine( "Dame el nombre" );
								nombre = Console.ReadLine();
								profesor.editarNombreCodigo( id, codigo,nombre);
							}
						}
						else{
							Console.WriteLine( "El id no existe presione cualquier tecla para continuar " );
      						 Console.ReadLine();
							}
							
      						break;
      						
      						
      					case 4: 
      						Console.WriteLine( "Dame el  ID del registro" );
							 id = Console.ReadLine();
      						if(profesor.Buscarid(id )){
							
							Console.WriteLine("¿Seguro que desea eliminarlo?" );
							string dig = Console.ReadLine();
							if(dig == "s")
								profesor.eliminarRegistroPorId( id);
							}
							else{
								Console.WriteLine( "El id no existe presione cualquier tecla para continuar " );
      							 Console.ReadLine();
      							
							}
							 
      						break;
      					case 5:
      						break;
 				
 				}
 				Console.WriteLine( "\t***Presione cualquier tecla para continuar*** " );
      			Console.ReadLine();
      			System.Console.Clear();
			}while( pal  < 5 );
			
			
			 
		}
	}
}