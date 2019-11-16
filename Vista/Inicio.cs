using Logica;
using Logica.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Transversal;

namespace Vista
{
	class Inicio : Textos
	{
		#region Variables
		static int n;
		static IUpdateBLL _Update = new UpdateBLL();
		static IQueryBLL _Query = new QueryBLL();
		static List<Point> points;
		static Point point;
		static QueryDatos queryDatos;
		static string[] t_nm = null;
		static string[] nm = null;
		static string[] s = null;
		static TextReader input = Console.In;
		static Int32 intValorAceptable;
		#endregion

		/// <summary>
		/// Inicio del programa
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{


			StringBuilder outp = new StringBuilder();
			Console.Write(strTexto1);
			int t = Convert.ToInt32(DatoDigitado(1)[0]);
			for (int i = 0; i < t; i++)
			{
				Console.Write(strTexto2);
				nm = DatoDigitado(2);
				n = Convert.ToInt32(nm[0]);
				int m = Convert.ToInt32(nm[1]);

				points = new List<Point>(m);
				for (int j = 1; j <= m; j++)
				{
					Console.Write(strTexto3 + j + "]: ");
					s = ValorDigitadoQUERYUPDATE();
					if (s[0] == "UPDATE")
					{
						// UPDATE x y z W
						point = new Point();
						point.X = Convert.ToInt32(s[1]);
						point.Y = Convert.ToInt32(s[2]);
						point.Z = Convert.ToInt32(s[3]);
						point.W = Convert.ToInt32(s[4]);
						_Update.Points = points;
						_Update.Update(point);
					}
					else
					{
						// QUERY x1 y1 z1 x2 y2 z2
						queryDatos = new QueryDatos();
						queryDatos.X1 = Convert.ToInt32(s[1]);
						queryDatos.Y1 = Convert.ToInt32(s[2]);
						queryDatos.Z1 = Convert.ToInt32(s[3]);
						queryDatos.X2 = Convert.ToInt32(s[4]);
						queryDatos.Y2 = Convert.ToInt32(s[5]);
						queryDatos.Z2 = Convert.ToInt32(s[6]);
						_Query.Points = points;
						outp.AppendLine(_Query.Query(queryDatos).ToString());
					}
				}
			}
			Console.Write(strTexto4);
			Console.WriteLine(outp.ToString());
			Console.Write(strTexto5);
			Console.ReadKey();
		}
		#region Métodos privados
		/// <summary>
		/// Método que se encarga de recibir el valor del usuario y tambien realiza la validación para aceptar un valor entero
		/// </summary>
		/// <param name="intOpcion">opción que identificar 1 para el primer valor digitado por el usuario y 2 para el segundo valor digitado por el usuario</param>
		/// <returns></returns>
		private static string[] DatoDigitado(int intOpcion)
		{
			bool boolValorAceptable = false;
			while (!boolValorAceptable)
			{
				try
				{
					t_nm = input.ReadLine().Split(' ');
					if (intOpcion == 1 && t_nm.Length == 1)
					{
						if (Int32.TryParse(t_nm[0], out intValorAceptable) && intOpcion == 1)

							boolValorAceptable = true;
					}
					if (intOpcion == 2 && t_nm.Length == 2)
					{
						if (Int32.TryParse(t_nm[0], out intValorAceptable) && Int32.TryParse(t_nm[1], out intValorAceptable))
							boolValorAceptable = true;
					}
					if (!boolValorAceptable)
						Console.Write(strTexto2Incorrecto);
				}
				catch
				{
					Console.Write(strTexto2Incorrecto);
				}
			}
			return t_nm;
		}
		/// <summary>
		/// Método que se encarga de recibir el valor digitado por el usuario como el QUERY Y UPDATE
		/// </summary>
		/// <returns>retorna un arreglo</returns>
		private static string[] ValorDigitadoQUERYUPDATE()
		{
			bool boolValorAceptable = false;
			while (!boolValorAceptable)
			{
				try
				{
					nm = input.ReadLine().Split(' ');
					if ((nm.Length == 5 && nm[0] == "UPDATE") || (nm.Length == 7 && nm[0] == "QUERY"))
					{
						for (int x = 1; x < nm.Length; x++)
						{
							if (Int32.TryParse(nm[x], out intValorAceptable))
							{
								boolValorAceptable = true;
							}
							else
							{
								Console.Write(strTexto2Incorrecto);
								boolValorAceptable = false;
							}
						}

					}
					else
						Console.Write(strTexto2Incorrecto);
				}
				catch
				{
					Console.Write(strTexto2Incorrecto);
				}
			}
			return nm;
		}
		#endregion
	}
}
