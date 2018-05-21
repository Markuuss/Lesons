using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Program;

namespace ConsoleApp1
{
    [TestFixture]
    public class SumServiceTests
    {
        [Test]
        public void Sum_One_And_One()
        {
            var sumService = new SumService();
            // act (акт)
            var result = sumService.Sum(1, 1);
            // assert (утверждение)
            Assert.AreEqual(2, result);
        }
        [Test]
        public void Sum_One_And_Two_Not_Equal_Five()
        {
            var sumService = new SumService();

            var result = sumService.Sum(1, 2);

            Assert.AreEqual(3, result);
        }

    }
}
