using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace NothingToSeeHere.Tests
{
    public class SomeTestFixture
    {
        [Fact]
        public void BasicTest()
        {
            Assert.Equal(3, 1+2);
        }
    }
}
