using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace torensvanhanoiopdr1
{
    internal class HanoiGame
    {
        private HanoiPole linkerPole = new HanoiPole("links");
        private HanoiPole middelPole = new HanoiPole("midden");
        private HanoiPole rechterPole = new HanoiPole("rechts");
        private bool even = false; //even == true / odd == false
        private long numberOfMoves = 0;
        public HanoiGame(int numberOfDiscs)
        {
            if (numberOfDiscs % 2 == 0)
            {
                even = true;
            }
            numberOfMoves = (long)(Math.Pow(2, numberOfDiscs) - 1);
            for (int i = 0; i < numberOfDiscs; i++) 
            {
                int discnumber = numberOfDiscs - i;
                linkerPole.putDown(new HanoiDisc(discnumber));
                Console.WriteLine("Disc " + discnumber + " created and pushed on stack");
            }
            Console.WriteLine("Game Created with " + numberOfDiscs + " discs");
            Console.WriteLine("This game requires " + numberOfMoves + " moves");
            printPoles();
            solveManualFour()//solveIterative();
        }
        public void printPoles()
        {
            linkerPole.printPole();
            middelPole.printPole();
            rechterPole.printPole();
        }   //solution for four discs
          
        public void solveManualFour()
        {
            middelPole.putDown(linkerPole.pickUp());
            rechterPole.putDown(linkerPole.pickUp());
            rechterPole.putDown(middelPole.pickUp());
            middelPole.putDown(linkerPole.pickUp());
            linkerPole.putDown(rechterPole.pickUp());
            middelPole.putDown(rechterPole.pickUp());
            middelPole.putDown(linkerPole.pickUp());
            rechterPole.putDown(linkerPole.pickUp());
            rechterPole.putDown(middelPole.pickUp());
            linkerPole.putDown(middelPole.pickUp());
            linkerPole.putDown(rechterPole.pickUp());
            rechterPole.putDown(middelPole.pickUp());
            middelPole.putDown(linkerPole.pickUp());
            rechterPole.putDown(linkerPole.pickUp());
            rechterPole.putDown(middelPole.pickUp());
            Console.WriteLine("final state");
            printPoles();
        }
        public void solveManualFive()
        {
            //solution for five discs
            rechterPole.putDown(linkerPole.pickUp());
            printPoles();
            middelPole.putDown(linkerPole.pickUp());
            printPoles();
            middelPole.putDown(rechterPole.pickUp());
            printPoles();
            rechterPole.putDown(linkerPole.pickUp());
            printPoles();
            linkerPole.putDown(middelPole.pickUp());
            printPoles();
            rechterPole.putDown(middelPole.pickUp());
            printPoles();
            rechterPole.putDown(linkerPole.pickUp());
            printPoles();
            middelPole.putDown(linkerPole.pickUp());
            printPoles();
            middelPole.putDown(rechterPole.pickUp());
            printPoles();
            linkerPole.putDown(rechterPole.pickUp());
            printPoles();
            linkerPole.putDown(middelPole.pickUp());
            printPoles();
            middelPole.putDown(rechterPole.pickUp());
            printPoles();
            rechterPole.putDown(linkerPole.pickUp());
            printPoles();
            middelPole.putDown(linkerPole.pickUp());
            printPoles();
            middelPole.putDown(rechterPole.pickUp());
            printPoles();
            rechterPole.putDown(linkerPole.pickUp());
            printPoles();
            linkerPole.putDown(middelPole.pickUp());
            printPoles();
            rechterPole.putDown(middelPole.pickUp());
            printPoles();
            rechterPole.putDown(linkerPole.pickUp());
            printPoles();
            linkerPole.putDown(middelPole.pickUp());
            printPoles();
            middelPole.putDown(rechterPole.pickUp());
            printPoles();
            linkerPole.putDown(rechterPole.pickUp());
            printPoles();
            linkerPole.putDown(middelPole.pickUp());
            printPoles();
            rechterPole.putDown(middelPole.pickUp());
            printPoles();
            rechterPole.putDown(linkerPole.pickUp());
            printPoles();
            middelPole.putDown(linkerPole.pickUp());
            printPoles();
            middelPole.putDown(rechterPole.pickUp());
            printPoles();
            rechterPole.putDown(linkerPole.pickUp());
            printPoles();
            linkerPole.putDown(middelPole.pickUp());
            printPoles();
            rechterPole.putDown(middelPole.pickUp());
            printPoles();
            rechterPole.putDown(linkerPole.pickUp());
            Console.WriteLine("final state");
            printPoles();
        }

        private void move(HanoiPole poleOne, HanoiPole poleTwo)
        {
            if (poleOne.isEmpty())
            {
                poleOne.putDown(poleTwo.pickUp());
            }
            else if (poleTwo.isEmpty())
            {
                poleTwo.putDown(poleOne.pickUp());
            }
            //so both poles are not empty
            else if (poleOne.lookIn().getSize() > poleTwo.lookIn().getSize())
            {
                //disc on poleOne is greater than disc on poleTwo, yielding a move from poleTwo to poleOne
                poleOne.putDown(poleTwo.pickUp());
            }
            else
            {
                //disc on poleTwo is greater than disc on poleOne, yielding a move from poleOne to poleTwo
                poleTwo.putDown(poleOne.pickUp());
            }
            //printcommands
            printPoles();
            Console.WriteLine("The number of moves to go: " + numberOfMoves);
            Console.WriteLine("===========================================================");
        }

        public void solveIterative()
        {
            while (numberOfMoves > 0 && even)
            {
                if (numberOfMoves > 0)
                {
                    move  /(linkerPole, middelPole);
                    numberOfMoves--;
                }
                if (numberOfMoves > 0)
                {
                    move(linkerPole, rechterPole);
                    numberOfMoves--;
                }
                if (numberOfMoves > 0)
                {
                    move(middelPole, rechterPole);
                    numberOfMoves--;
                }
            }
            while (numberOfMoves > 0 && !even)
            {
                if (numberOfMoves > 0)
                {
                    move(linkerPole, rechterPole);
                    numberOfMoves--;
                }
                if (numberOfMoves > 0)
                {
                    move(linkerPole, middelPole);
                    numberOfMoves--;
                }
                if (numberOfMoves > 0)
                {
                    move(middelPole, rechterPole);
                    numberOfMoves--;
                }
            }
            Console.WriteLine("final state");
            printPoles();
        }


    }
}
