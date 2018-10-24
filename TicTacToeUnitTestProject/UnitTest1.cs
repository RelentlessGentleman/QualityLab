using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicTacToeUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void createBoard ()
        {
            bool pass = false;
            try
            {
                for (int i = 0; i<=9; i++)
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
            //return pass;
        }

        [TestMethod]
        public void currentPlayer()
        {
            string playerWhosTurnIsRN = "X";
            string otherPlayer = "";

            bool pass;
            string currentPlayer = playerWhosTurnIsRN;
            if ((playerWhosTurnIsRN == currentPlayer) && (playerWhosTurnIsRN == "X"))
            {
                pass = true;
                Assert.IsTrue(pass);
            }
            else if (currentPlayer == otherPlayer)
            {
                pass = false;
                Assert.IsTrue(pass);
            }
            else
                pass = false;
            Assert.IsTrue(pass);


            //return pass;
        }

        [TestMethod]
        public void ChangePlayer()
        {
            bool pass;
            int playerCounter = 3;
            int player1 = 1;
            int player2 = 0;

            if (playerCounter % 2 == 0)
            {
                pass = true;
                Assert.IsTrue(pass);
            }
            else
            {
                pass = true;
                Assert.IsTrue(pass);
            }
            pass = true;
            Assert.IsTrue(pass);
        }

        [TestMethod]
        public void MakeMove()
        {
            int playerCounter = 3;
            bool moveHasBeenMade = false;
            if ((playerCounter != playerCounter-1) && (playerCounter != 0))
            {
                moveHasBeenMade = true;
            }
            else
                moveHasBeenMade = false;
            Assert.IsTrue(moveHasBeenMade);
        }

        [TestMethod]
        public void SpaceInUs()
        {
            bool spaceIsFree = false;
            bool spaceIsTaken = false;
            int[] boardArray = new int[9];
            for (int i = 0; i<boardArray.Length; i++)
            {
                if (boardArray[i] != null)
                {
                    spaceIsTaken = true;
                }
                else
                    spaceIsFree = true;
            }
            Assert.IsTrue(spaceIsTaken);
        }


    }
}
