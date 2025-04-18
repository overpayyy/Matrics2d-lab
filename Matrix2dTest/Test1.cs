using Matrics2dLib;

namespace Matrix2dTest
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void Konstructor_WieleArgumentow_Poprawnie_OK()
        {
            var m = new Matrix2d(1, 2, 3, 4);

            Assert.AreEqual(1, m.A);
            Assert.AreEqual(2, m.B);
            Assert.AreEqual(3, m.C);
            Assert.AreEqual(4, m.D);
        }

        [TestMethod]
        public void Konstructor_BezArgumentow_Poprawnie_OK()
        {
            var m = new Matrix2d();

            Assert.AreEqual(1, m.A);
            Assert.AreEqual(0, m.B);
            Assert.AreEqual(0, m.C);
            Assert.AreEqual(1, m.D);
        }

        [TestMethod]
        public void Operator_Dodawania_Poprawnie_OK()
        {
            var m1 = new Matrix2d(1, 2, 3, 4);
            var m2 = new Matrix2d(5, 6, 7, 8);

            var result = m1 + m2;

            Assert.AreEqual(6, result.A);
            Assert.AreEqual(8, result.B);
            Assert.AreEqual(10, result.C);
            Assert.AreEqual(12, result.D);
        }

        [TestMethod]
        public void Operator_Odejmowania_Poprawnie_OK()
        {
            var m1 = new Matrix2d(5, 6, 7, 8);
            var m2 = new Matrix2d(1, 2, 3, 4);

            var result = m1 - m2;

            Assert.AreEqual(4, result.A);
            Assert.AreEqual(4, result.B);
            Assert.AreEqual(4, result.C);
            Assert.AreEqual(4, result.D);
        }

        [TestMethod]
        public void Operator_MnozeniaMacierzy_Poprawnie_OK()
        {
            var m1 = new Matrix2d(1, 2, 3, 4);
            var m2 = new Matrix2d(5, 6, 7, 8);

            var result = m1 * m2;

            Assert.AreEqual(19, result.A);
            Assert.AreEqual(22, result.B);
            Assert.AreEqual(43, result.C);
            Assert.AreEqual(50, result.D);
        }

        [TestMethod]
        public void Operator_MnozeniaPrzezSkalar_Poprawnie_OK()
        {
            var m = new Matrix2d(1, 2, 3, 4);

            var result = 2 * m;

            Assert.AreEqual(2, result.A);
            Assert.AreEqual(4, result.B);
            Assert.AreEqual(6, result.C);
            Assert.AreEqual(8, result.D);
        }

        [TestMethod]
        public void Determinant_Poprawnie_OK()
        {
            var m = new Matrix2d(1, 2, 3, 4);

            var det = m.Det();

            Assert.AreEqual(-2, det);
        }

        [TestMethod]
        public void Transpose_Poprawnie_OK()
        {
            var m = new Matrix2d(1, 2, 3, 4);

            var transposed = Matrix2d.Transpose(m);

            Assert.AreEqual(1, transposed.A);
            Assert.AreEqual(3, transposed.B);
            Assert.AreEqual(2, transposed.C);
            Assert.AreEqual(4, transposed.D);
        }

        [TestMethod]
        public void Parse_Poprawnie_OK()
        {
            var input = "[1, 2], [3, 4]";

            var m = Matrix2d.Parse(input);

            Assert.AreEqual(1, m.A);
            Assert.AreEqual(2, m.B);
            Assert.AreEqual(3, m.C);
            Assert.AreEqual(4, m.D);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Parse_NieprawidlowyFormat_Wyjatek()
        {
            var input = "Niepoprawny format";

            Matrix2d.Parse(input);
        }
    }
}