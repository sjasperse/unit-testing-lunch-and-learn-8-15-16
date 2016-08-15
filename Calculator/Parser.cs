using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NCalc;

namespace Calculator
{
	public class Parser
	{
		public decimal Evaluate(string expression, Dictionary<string, object> parameters = null)
		{
			// punting and using NCalc because this demonstration is about testing, and not
			// about implementation.
			// I would have liked to do a TDD demo, but time didn't allow.

			var ncalcExpression = new Expression(expression);

			if (parameters != null)
			{
				ncalcExpression.Parameters = parameters;
			}

			return Convert.ToDecimal(ncalcExpression.Evaluate());
		}
	}
}