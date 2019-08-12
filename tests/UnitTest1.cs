using System;
using Xunit;
using c_sharp_coverage_exploration;

namespace tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Sequence c1 = new Sequence();
            Assert.True(c1.isSuhuPadat(50));
        }
    }
}
