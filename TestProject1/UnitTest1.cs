using Education;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    
        [Test]
        public void CalcTest()
        {
            double a = 2;
            double b = 2;
            double expected = 4;
            var calc = new Calculate();

            double actual = calc.ToCalculate(a,b);
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void CalcTest1()
        {
            double a = 2;
            double b = 3;
            double expected = 5;
            var calc = new Calculate();
            // действие
            double actual = calc.ToCalculate(a, b);
            // утверждение
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void PrimeFactoryTest()
        {
            int a = 1000000;
            string expected = "2*2*2*2*2*2*5*5*5*5*5*5";
            var prime = new PrimeFactors();
            // действие
            string actual = prime.GetPrimeFactors(a);
            // утверждение
            Assert.AreEqual(expected, actual);
        }
    }
}

