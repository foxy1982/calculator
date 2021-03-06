﻿using FluentAssertions;
using NUnit.Framework;

namespace calculator.test
{
    [TestFixture]
    public class QueryParserTests
    {
        [Test]
        public void ItShouldParseValidString()
        {
            var valid = "4 x 18";

            var target = new QueryParser();
            var result = target.Parse(valid);

            result.ShouldBeEquivalentTo(new Calculation("x", 4, 18));
        }
    }
}