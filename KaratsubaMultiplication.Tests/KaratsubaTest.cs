using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KaratsubaMultiplication.Common;
using System.Numerics;

namespace KaratsubaMultiplication.Tests
{
    [TestClass]
    public class KaratsubaTest
    {
        [TestMethod]
        public void MultiplyOnes()
        {
            #region ARRANGE
            #endregion

            #region ACT
            BigInteger Result = KaratsubaAlgorithm.Multiply(1, 1, 1);
            #endregion

            #region ASSERT
            Assert.AreEqual(Result, 1);
            #endregion
        }

        [TestMethod]
        public void MultiplyBasic()
        {
            #region ARRANGE
            #endregion

            #region ACT
            BigInteger Result = KaratsubaAlgorithm.Multiply(1, 2, 5);
            #endregion

            #region ASSERT
            Assert.AreEqual(Result, 10);
            #endregion
        }

        [TestMethod]
        public void MultiplyZeros()
        {
            #region ARRANGE
            #endregion

            #region ACT
            BigInteger Result = KaratsubaAlgorithm.Multiply(1, 0, 0);
            #endregion

            #region ASSERT
            Assert.AreEqual(Result, 0);
            #endregion
        }

        [TestMethod]
        public void MultiplyTwoDigit()
        {
            #region ARRANGE
            #endregion

            #region ACT
            BigInteger Result = KaratsubaAlgorithm.Multiply(2, 56, 12);
            #endregion

            #region ASSERT
            Assert.AreEqual(Result, 672);
            #endregion
        }

        [TestMethod]
        public void MultiplyFourDigit()
        {
            #region ARRANGE
            #endregion

            #region ACT
            BigInteger Result = KaratsubaAlgorithm.Multiply(4, 5678, 1234);
            #endregion

            #region ASSERT
            Assert.AreEqual(Result, 7006652);
            #endregion
        }

        [TestMethod]
        public void Multiply64Digit()
        {
            #region ARRANGE
            #endregion

            #region ACT
            BigInteger Result = KaratsubaAlgorithm.Multiply(64, 
                BigInteger.Parse("3141592653589793238462643383279502884197169399375105820974944592"),
                BigInteger.Parse("2718281828459045235360287471352662497757247093699959574966967627"));
            #endregion

            #region ASSERT
            Assert.AreEqual(Result, BigInteger.Parse("8539734222673567065463550869546574495034888535765114961879601127067743044893204848617875072216249073013374895871952806582723184"));
            #endregion
        }
    }
}
