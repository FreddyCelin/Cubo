using Logica.Interface;
using System.Collections.Generic;
using Transversal;

namespace Logica
{
	public class UpdateBLL : IUpdateBLL
	{
		#region Atributos y propiedades
		/// <summary>
		/// Atributo list points
		/// </summary>
		List<Point> points;
		/// <summary>
		/// Encapsula el atributo de lista points
		/// </summary>
		public List<Point> Points { get => points; set => points = value; }
		#endregion
		#region Método público
		// UPDATE x y z W
		/// <summary>
		/// Método que realiza la funcion de UPDATE: actualiza el valor del bloque (x, y, z) a W.
		/// </summary>
		/// <param name="point">Objeto que representa los datos a comparar o asignar</param>
		public void Update(Point point)
		{
			Point up = null;
			foreach (Point p in Points)
			{
				if (p.X == point.X && p.Y == point.Y && p.Z == point.Z)
				{
					up = p;
					break;
				}
			}
			if (up == null)
			{
				up = new Point { X = point.X, Y = point.Y, Z = point.Z };
				Points.Add(up);
			}
			up.W = point.W;
		}
		#endregion
	}
}
