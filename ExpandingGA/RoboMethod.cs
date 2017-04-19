using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GeneticAlgorithmForStrings
{
		internal class RoboMethod
		{
			public string MethodName { get; set; }
			public Queue TypeRequired { get; set; }

			public RoboMethod(string name, List<RoboMethodTypes> order) {
				MethodName = name;
				TypeRequired = new Queue();
				foreach (var type in order)
				{
					TypeRequired.Enqueue(type);
				}
			}
	}
}