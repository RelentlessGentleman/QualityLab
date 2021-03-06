// <copyright file="UnitTest1Test.cs">Copyright ©  2018</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToeUnitTestProject;

namespace TicTacToeUnitTestProject.Tests
{
    /// <summary>This class contains parameterized unit tests for UnitTest1</summary>
    [PexClass(typeof(UnitTest1))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class UnitTest1Test
    {
        /// <summary>Test stub for ChangePlayer(Int32, String, String)</summary>
        [PexMethod]
        public string ChangePlayerTest(
            [PexAssumeUnderTest]UnitTest1 target,
            int playerCounter,
            string player1,
            string player2
        )
        {
            string result = target.ChangePlayer(playerCounter, player1, player2);
            return result;
            // TODO: add assertions to method UnitTest1Test.ChangePlayerTest(UnitTest1, Int32, String, String)
        }
    }
}
