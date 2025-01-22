using System.Collections.Generic;

namespace EvaluationSampleCode.UnitTests
{
    [TestClass]
    public sealed class MathOperationsUnitTest
    {
        private MathOperations _mathOperations;

        [TestInitialize]
        public void Init()
        {
            _mathOperations = new MathOperations();
        }

        [TestMethod]
        [DataRow(20, 2)]
        public void Add_TwoPositiveValues_ReturnAddition(int numberOne, int numberTwo)
        {
            int result = _mathOperations.Add(numberOne, numberTwo);

            Assert.AreEqual(result, 22);
        }

        [TestMethod]
        [DataRow(-29, -31)]
        public void Add_TwoNegativeValues_ReturnAddition(int numberOne, int numberTwo)
        {
            int result = _mathOperations.Add(numberOne, numberTwo);

            Assert.AreEqual(result, -60);
        }

        [TestMethod]
        [DataRow(31, -29)]
        public void Add_PositiveAndNegativeValues_ReturnAddition(int numberOne, int numberTwo)
        {
            int result = _mathOperations.Add(numberOne, numberTwo);

            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        [DataRow(0, -29)]
        public void Add_NullAndNegativeValues_ReturnAddition(int numberOne, int numberTwo)
        {
            int result = _mathOperations.Add(numberOne, numberTwo);

            Assert.AreEqual(result, -29);
        }

        [TestMethod]
        [DataRow(-18, -29)]
        public void Divide_TwoNegativeValues_ReturnDivision(int numberOne, int numberTwo)
        {
            float result = _mathOperations.Divide(numberOne, numberTwo);

            Assert.AreEqual(result, 0.620689631f);
        }

        [TestMethod]
        [DataRow(20, 10)]
        public void Divide_TwoPositiveValues_ReturnDivision(int numberOne, int numberTwo)
        {
            float result = _mathOperations.Divide(numberOne, numberTwo);

            Assert.AreEqual(result, 2.0f);
        }

        [TestMethod]
        [DataRow(200, -10)]
        public void Divide_PositiveAndNegativeValues_ReturnDivision(int numberOne, int numberTwo)
        {
            float result = _mathOperations.Divide(numberOne, numberTwo);

            Assert.AreEqual(result, -20.0f);
        }

        [TestMethod]
        [DataRow(0, -11)]
        public void Divide_NullAndNegativeValues_ReturnDivision(int numberOne, int numberTwo)
        {
            float result = _mathOperations.Divide(numberOne, numberTwo);

            Assert.AreEqual(result, 0.0f);
        }

        [TestMethod]
        [DataRow(12, 0)]
        public void Divide_NullNumberTwo_ThrowsArgumentException(int numberOne, int numberTwo)
        {
            Assert.ThrowsException<ArgumentException>(() => _mathOperations.Divide(numberOne, numberTwo));
        }


        [TestMethod]
        [DataRow(7)]
        public void GetOddNumbers__ReturnValidList(int limit)
        {
            IEnumerable<int> validList = new List<int> { 1, 3, 5, 7 };
            IEnumerable<int> result = _mathOperations.GetOddNumbers(limit);
            CollectionAssert.AreEqual(result.ToList(), validList.ToList());
        }

        [TestMethod]
        [DataRow(7)]
        public void GetOddNumbers__ReturnInvalidList(int limit)
        {
            IEnumerable<int> validList = new List<int> { 2, 4, 5 };
            IEnumerable<int> result = _mathOperations.GetOddNumbers(limit);
            CollectionAssert.AreNotEqual(result.ToList(), validList.ToList());
        }


        [TestMethod]
        [DataRow(-5)]
        public void GetOddNumbers_ThrowsArgumentException(int limit)
        {
            Assert.ThrowsException<ArgumentException>(() => _mathOperations.GetOddNumbers(limit));
        }
    }
}
