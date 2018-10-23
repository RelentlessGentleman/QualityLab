using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Tests
{
    [TestClass()]
    public class frmMainTests
    {
        [TestMethod()]
        public void frmMainTest(int[] boardSize)
        {
            frmMain import = new frmMain();
            bool pass = false;
            try
            {
                for (int i = 0; i <= boardSize.Length; i++)
                {
                    if (i == 9)
                    {
                        pass = true;
                    }
                }
            }
            catch (Exception e)
            {
                pass = false;
            }
            Assert.IsTrue(pass);
        }
    }
}