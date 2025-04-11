using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SqlSearch.UI.Tests
{
    [TestClass]
    public class IsNullOrWhitespaceConverterTests
    {
        #region Strings

        [TestMethod]
        public void Null_Returns_True()
        {
            IsNullOrWhitespaceConverter converter = new();

            object result = converter.Convert(null, null, null, null);
            Assert.IsTrue((bool)result);
        }

        [TestMethod]
        public void Tab_Returns_True()
        {
            IsNullOrWhitespaceConverter converter = new();

            object result = converter.Convert("\t", null, null, null);
            Assert.IsTrue((bool)result);
        }

        [TestMethod]
        public void Space_Returns_True()
        {
            IsNullOrWhitespaceConverter converter = new();

            object result = converter.Convert(" ", null, null, null);
            Assert.IsTrue((bool)result);
        }

        [TestMethod]
        public void NewLine_Returns_True()
        {
            IsNullOrWhitespaceConverter converter = new();

            object result = converter.Convert(Environment.NewLine, null, null, null);
            Assert.IsTrue((bool)result);
        }

        [TestMethod]
        public void ClassName_Returns_False()
        {
            IsNullOrWhitespaceConverter converter = new();

            object result = converter.Convert(nameof(IsNullOrWhitespaceConverter), null, null, null);
            Assert.IsFalse((bool)result);
        }

        #endregion

        #region Objects

        [TestMethod]
        public void Null_Wrong_Type_Returns_True()
        {
            IsNullOrWhitespaceConverter converter = new();

            object result = converter.Convert((IsNullOrWhitespaceConverter)null, null, null, null);
            Assert.IsTrue((bool)result);
        }


        [TestMethod]
        public void Instance_Wrong_Type_Returns_True()
        {
            IsNullOrWhitespaceConverter converter = new();

            object result = converter.Convert(new IsNullOrWhitespaceConverter(), null, null, null);
            Assert.IsTrue((bool)result);
        }

        #endregion

        #region ConvertBack

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void ConvertBack_Throws_NotImplementedException()
        {
            IsNullOrWhitespaceConverter converter = new();

            object result = converter.ConvertBack(null, null, null, null);
        }

        #endregion
    }
}
