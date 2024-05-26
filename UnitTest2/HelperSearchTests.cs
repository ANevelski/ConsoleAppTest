namespace UnitTests
{
    public class Tests
    {
        [TestCase(null)]
        [TestCase(new int[0])]
        public void NullParametrArgCheck(int[] input)
        {
            // Arrange and Act
            var expectedMessage = "The input array coud not be Null or lenght should be at least 3 or more.";
            var ex = Assert.Throws<ArgumentException>(() => MainApp.Program.HelperSearch(input));

            // Assert
            Assert.That(ex.Message, Is.EqualTo(expectedMessage));
        }

        [Test]
        public void NotNullParametrArgWithNoResult_Check()
        {
            // Arrange
            var expectedMessage = "The indexes were not found.";
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            MainApp.Program.HelperSearch([0, 0, 0]);

            // Assert
            var actionOutput = stringWriter.ToString().Trim();
            Assert.That(actionOutput, Is.EqualTo(expectedMessage));
        }

        [TestCase(new int[3] { 3, 3, 13}, "The folowing indexes were found: 2") ]
        [TestCase(new int[4] { 3, 3, 13, 33}, "The folowing indexes were found: 2; 3")]
        [TestCase(new int[5] { 3, 3, 13, 33, 0}, "The folowing indexes were found: 2; 3")]
        [TestCase(new int[6] { 3, 3, 13, 33, 0, 67}, "The folowing indexes were found: 2; 3; 5")]
        public void NotNullParametrArgWitOnehResult_Check(int[] input, string resultMessage)
        {     
            // Arrange
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            MainApp.Program.HelperSearch(input);

            // Assert
            var actionOutput = stringWriter.ToString().Trim();
            Assert.That(actionOutput, Is.EqualTo(resultMessage));
        }
    }
}