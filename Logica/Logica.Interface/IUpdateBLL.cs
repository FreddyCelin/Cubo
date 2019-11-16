using System.Collections.Generic;
using Transversal;

namespace Logica.Interface
{
	public interface IUpdateBLL: IListPoints
	{
		/// <summary>
		/// Método que realiza la funcion de UPDATE: actualiza el valor del bloque (x, y, z) a W.
		/// </summary>
		/// <param name="point">Objeto que representa los datos a comparar o asignar</param>
		void Update(Point point);
	}
}
