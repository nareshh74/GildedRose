using GildedRose.Console;
using System.Collections.Generic;
using Xunit;

namespace GildedRose.Tests
{
    public class TestAssemblyTests
    {
        [Fact]
        public void TestTheTruth()
        {
            Assert.True(true);
        }

        [Fact]
        public void UpdateQualityShouldNotThrowException()
        {
            var app = new Program()
            {
                Items = new List<Item>()
            };
            app.UpdateQuality();
            Assert.True(true);
        }
    }
}