using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transversal;

namespace Logica.Interface
{
	public interface IListPoints
	{
		/// <summary>
		/// Encapsula el atributo de lista points
		/// </summary>
		List<Point> Points { get; set; }
	}
}
