using System;
using System.Collections.Generic;
using Logica;
using Logica.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transversal;

namespace PruebasaLogica
{
	[TestClass]
	public class UpdateTest
	{
		IUpdateBLL _Update = new UpdateBLL();
		List<Point> points;
		Point point;
		[TestMethod]
		public void TestMethod1()
		{
			points = new List<Point>(0);

			point = new Point() { X = 2, Y = 2, Z = 2, W = 4 };
			points.Add(point);

			_Update.Points = points;
			_Update.Update(point);
			Assert.IsTrue(_Update.Points.Count>0);
		}
	}
}
