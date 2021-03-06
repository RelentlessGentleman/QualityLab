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
        /// <summary>Test stub for createBoard(Int32[])</summary>
        [PexMethod]
        public void createBoardTest([PexAssumeUnderTest]UnitTest1 target, int[] boardSize)
        {
            target.createBoard(boardSize);
            // TODO: add assertions to method UnitTest1Test.createBoardTest(UnitTest1, Int32[])
        }
    }
}
