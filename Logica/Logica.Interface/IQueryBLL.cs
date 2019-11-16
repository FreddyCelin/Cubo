using System.Collections.Generic;
using System.Numerics;
using Transversal;

namespace Logica.Interface
{
	public interface IQueryBLL: IListPoints
	{
		/// <summary>
		/// Método que realiza la funcion QUERY:calcula la suma del valor de los bloques cuya coordenada x está entre x1 y x2 (inclusive), la coordenada y entre y1 e y2 (inclusive) y la coordenada z entre z1 y z2 (inclusive).
		/// </summary>
		/// <param name="queryDatos"></param>
		/// <returns>entero</returns>
		BigInteger Query(QueryDatos queryDatos);
	}
}
