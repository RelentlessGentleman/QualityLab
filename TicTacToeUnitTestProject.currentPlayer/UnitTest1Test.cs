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
        /// <summary>Test stub for currentPlayer(String, String)</summary>
        [PexMethod]
        public string currentPlayerTest(
            [PexAssumeUnderTest]UnitTest1 target,
            string playerWhosTurnIsRN,
            string otherPlayer
        )
        {
            string result = target.currentPlayer(playerWhosTurnIsRN, otherPlayer);
            return result;
            // TODO: add assertions to method UnitTest1Test.currentPlayerTest(UnitTest1, String, String)
        }
    }
}
