using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSpec;

namespace Calculator.Tests.NSpec
{
	public class NSpecTests : nspec
	{
		// these can be run by running this command in the Package Manager Console
		// & '.\Run NSpec tests.ps1'

		public void Parser_Specs()
		{
			Parser parser = new Parser();
			string expression = null;
			Dictionary<string, object> parameters = new Dictionary<string, object>();
			decimal? result = null;

			act = () =>
			{
				result = parser.Evaluate(expression, parameters);
			};

			context["when parsing the expression 1+1"] = () =>
			{
				before = () =>
				{
					expression = "1+1";
				};

				it["should result in 2"] = () => result.should_be(2);
			};

			context["when parsing the expression x+1"] = () =>
			{
				before = () =>
				{
					expression = "x+1";
				};

				context["when x = 2"] = () =>
				{
					before = () =>
					{
						parameters["x"] = 2;
					};

					it["should result in 3"] = () => result.should_be(3);
				};

				context["when x = 3"] = () =>
				{
					before = () =>
					{
						parameters["x"] = 3;
					};

					it["should result in 4"] = () => result.should_be(4);
				};
			};
		}
	}
}