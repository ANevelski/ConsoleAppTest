using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Main_App;

namespace UnitTests
{
    [TestClass]
    public class HelperSearchTests
    {
        [TestMethod]
        public void CheckNullParameter()
        {
            List<int> result = Program.HelperSearch(null);

        }
}
}
