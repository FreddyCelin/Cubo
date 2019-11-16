using System;
using System.Collections.Generic;
using System.Numerics;
using Transversal;
using Logica.Interface;

namespace Logica
{
	public class QueryBLL : IQueryBLL
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
		// QUERY x1 y1 z1 x2 y2 z2
		/// <summary>
		/// Método que realiza la funcion QUERY:calcula la suma del valor de los bloques cuya coordenada x está entre x1 y x2 (inclusive), la coordenada y entre y1 e y2 (inclusive) y la coordenada z entre z1 y z2 (inclusive).
		/// </summary>
		/// <param name="queryDatos"></param>
		/// <returns>entero</returns>
		public BigInteger Query(QueryDatos queryDatos)
		{
			BigInteger res = 0;
			foreach (Point p in points)
			{
				if (p.X >= queryDatos.X1 && p.X <= queryDatos.X2
					&& p.Y >= queryDatos.Y1 && p.Y <= queryDatos.Y2
					&& p.Z >= queryDatos.Z1 && p.Z <= queryDatos.Z2)
				{
					res += p.W;
				}
			}
			return res;
		}
		#endregion
	}
}
