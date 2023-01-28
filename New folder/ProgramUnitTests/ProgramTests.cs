
namespace ProgramTests
{
    public class ProgramTests
    {
       
        [Test]
        public void Test_ProgramSum_ThreePositiveNumbers()
        {
            string input = "5 10 12";
            var writer = new StringWriter();    
            Console.SetOut(writer); //Redirect Console.Out
            var reader = new StringReader(input);
            Console.SetIn(reader); //Redirect Console.IN

            Program.Main();

            var actualResults = writer.ToString();
            var expectedResults = "The sum is: " + Environment.NewLine + "27" + Environment.NewLine;
            Assert.AreEqual(expectedResults, actualResults);

        }
        [Test]
        public void Test_ProgramSum_TwoNegativeNumbers()
        {
            string input = "-1 -22";
            var writer = new StringWriter();
            Console.SetOut(writer); //Redirect Console.Out
            var reader = new StringReader(input);
            Console.SetIn(reader); //Redirect Console.IN

            Program.Main();

            var actualResults = writer.ToString();
            var expectedResults = "The sum is: " + Environment.NewLine + "-23" + Environment.NewLine;
            Assert.AreEqual(expectedResults, actualResults);

        }
        [Test]
        public void Test_ProgramSum_OnePositiveNumberAndOneNegativeNumber()
        {
            string input = "-5 10";
            var writer = new StringWriter();
            Console.SetOut(writer); //Redirect Console.Out
            var reader = new StringReader(input);
            Console.SetIn(reader); //Redirect Console.IN

            Program.Main();

            var actualResults = writer.ToString();
            var expectedResults = "The sum is: " + Environment.NewLine + "5" + Environment.NewLine;
            Assert.AreEqual(expectedResults, actualResults);

        }
        [Test]
        public void Test_ProgramSum_ZeroAndOnePositiveNumber()
        {
            string input = "0 1";
            var writer = new StringWriter();
            Console.SetOut(writer); //Redirect Console.Out
            var reader = new StringReader(input);
            Console.SetIn(reader); //Redirect Console.IN

            Program.Main();

            var actualResults = writer.ToString();
            var expectedResults = "The sum is: " + Environment.NewLine + "1" + Environment.NewLine;
            Assert.AreEqual(expectedResults, actualResults);

        }
        [Test]
        public void Test_ProgramSum_ZeroAndOneNegativeNumber()
        {
            string input = "0 -99";
            var writer = new StringWriter();
            Console.SetOut(writer); //Redirect Console.Out
            var reader = new StringReader(input);
            Console.SetIn(reader); //Redirect Console.IN

            Program.Main();

            var actualResults = writer.ToString();
            var expectedResults = "The sum is: " + Environment.NewLine + "-99" + Environment.NewLine;
            Assert.AreEqual(expectedResults, actualResults);

        }
        [Test]
        public void Test_ProgramSum_TwoBigPositiveNumbers()
        {
            string input = "2000000000 2000000000";
            var writer = new StringWriter();
            Console.SetOut(writer); //Redirect Console.Out
            var reader = new StringReader(input);
            Console.SetIn(reader); //Redirect Console.IN

            Program.Main();

            var actualResults = writer.ToString();
            var expectedResults = "The sum is: " + Environment.NewLine + "4000000000" + Environment.NewLine;
            Assert.AreEqual(expectedResults, actualResults);

        }
        [Test]
        public void Test_ProgramSum_TwoBigNegativeNumbers()
        {
            string input = "-2000000000 -2000000000";
            var writer = new StringWriter();
            Console.SetOut(writer); //Redirect Console.Out
            var reader = new StringReader(input);
            Console.SetIn(reader); //Redirect Console.IN

            Program.Main();

            var actualResults = writer.ToString();
            var expectedResults = "The sum is: " + Environment.NewLine + "-4000000000" + Environment.NewLine;
            Assert.AreEqual(expectedResults, actualResults);

        }
        [Test]
        public void Test_ProgramSum_TwoPositiveNumbersAndTwoNegativeNumbers()
        {
            string input = "5 10 -12 -13";
            var writer = new StringWriter();
            Console.SetOut(writer); //Redirect Console.Out
            var reader = new StringReader(input);
            Console.SetIn(reader); //Redirect Console.IN

            Program.Main();

            var actualResults = writer.ToString();
            var expectedResults = "The sum is: " + Environment.NewLine + "-10" + Environment.NewLine;
            Assert.AreEqual(expectedResults, actualResults);

        }
    }
}