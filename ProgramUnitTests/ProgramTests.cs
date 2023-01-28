using ConsoleInputSample;

namespace ProgramTests
{
    public class ProgramTests
    {
       
        [Test]
        public void Test_ProgramSum_TwoPositiveNumbers()
        {
            string input = "5 10 12";
            var writer = new StringWriter();    
            Console.SetOut(writer);
            var reader = new StringReader(input);
            Console.SetIn(reader);

            Program.Main();

            var actualResults = writer.ToString();
            var expectedResults = "The sum is: " + Environment.NewLine + "27" + Environment.NewLine;
            Assert.AreEqual(expectedResults, actualResults);

        }
    }
}