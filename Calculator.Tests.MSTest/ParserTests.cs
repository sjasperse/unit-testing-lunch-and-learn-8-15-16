using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests.MSTest
{
	[TestClass]
	public class ParserTests
	{
		[TestMethod]
		public void Parser_Evaluate_1Plus1_ShouldBe2()
		{
			var parser = new Parser();
			parser.Evaluate("1+1")
				.Should().Be(2);
		}

		[TestMethod]
		public void Parser_Evaluate_XPlus1_WhenXIs2_ShouldBe3()
		{
			var parser = new Parser();
			var parameters = new Dictionary<string, object>();

			parameters["x"] = 2;

			parser.Evaluate("x+1", parameters)
				.Should().Be(3);
		}

		[TestMethod]
		public void Parser_Evaluate_XPlus1_WhenXIs3_ShouldBe4()
		{
			var parser = new Parser();
			var parameters = new Dictionary<string, object>();

			parameters["x"] = 3;

			parser.Evaluate("x+1", parameters)
				.Should().Be(4);
		}
	}
}