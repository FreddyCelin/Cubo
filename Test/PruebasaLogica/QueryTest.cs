using System;
using System.Collections.Generic;
using System.Numerics;
using Logica;
using Logica.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transversal;

namespace PruebasaLogica
{
	[TestClass]
	public class QueryTest
	{
		IQueryBLL _queryBLL;
		QueryDatos queryDatos;
		List<Point> points;
		Point point;
		[TestMethod]
		public void TestMethod1()
		{
			//Arranque
			points = new List<Point>(1);
			point = new Point() { X = 2, Y = 2, Z = 2, W = 4 };
			points.Add(point);

			queryDatos = new QueryDatos();
			queryDatos.X1 = Convert.ToInt32(1);
			queryDatos.Y1 = Convert.ToInt32(1);
			queryDatos.Z1 = Convert.ToInt32(1);
			queryDatos.X2 = Convert.ToInt32(3);
			queryDatos.Y2 = Convert.ToInt32(3);
			queryDatos.Z2 = Convert.ToInt32(3);
			_queryBLL = new QueryBLL();
			_queryBLL.Points = points;
			//Act
			BigInteger Resultado = _queryBLL.Query(queryDatos);
			Assert.IsNotNull(Resultado);
		}
	}
}
