using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calculator;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace Calculator.Tests.SpecFlow
{
	[Binding]
	public sealed class ParserSteps
	{
		private string expression = null;
		private Dictionary<string, object> parameters = new Dictionary<string, object>();
		private decimal? result = null;

		[Given(@"the expression ""(.*)""")]
		public void GivenTheExpression(string expression)
		{
			this.expression = expression;
		}

		[Given(@"that parameter (\w*) = (.*)")]
		public void GivenThatParamEqualValue(string paramName, decimal value)
		{
			parameters[paramName] = value;
		}

		[When(@"it is parsed")]
		public void WhenItIsParsed()
		{
			var parser = new Parser();
			result = parser.Evaluate(expression, parameters);
		}

		[Then(@"the result should be ""(.*)""")]
		public void ThenTheResultShouldBe(decimal result)
		{
			this.result.Should().Be(result);
		}
	}
}