namespace UnitTest_HW
{
    public class Tests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void MultiplyReturnCorrectResult()
        {
            int a = 5;
            int b = 10;

            int result = calculator.Multiply(a, b);





            Assert.That(result, Is.EqualTo(50));
        }

        [Test]
        public void DivideReturnCorrectResult()
        {
            int a = 10;
            int b = 2;

            int result = calculator.Divide(a, b);

            Assert.That(result, Is.EqualTo(5));
        }
    }
}