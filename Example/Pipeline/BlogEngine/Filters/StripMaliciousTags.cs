﻿using System;
using Tamarack.Pipeline;

namespace Tamarack.Example.Pipeline.BlogEngine.Filters
{
	public class StripMaliciousTags : IFilter<Post, int>
	{
		public int Execute(Post context, Func<Post, int> executeNext)
		{
			throw new NotImplementedException();
		}
	}
}