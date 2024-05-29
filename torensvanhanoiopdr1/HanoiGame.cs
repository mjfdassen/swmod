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
        HanoiPole linkerPole = new HanoiPole("links");
        HanoiPole middelPole = new HanoiPole("midden");
        HanoiPole rechterPole = new HanoiPole("rechts");
        public HanoiGame(int numberOfDiscs)
        {
            for (int i = 0; i < numberOfDiscs; i++) 
            {
                int discnumber = numberOfDiscs - i;
                linkerPole.putDown(new HanoiDisc(discnumber));
                Console.WriteLine("Disc " + discnumber + " created and pushed on stack");
            }
            Console.WriteLine("Game Created with " + numberOfDiscs + " discs");
            printPoles();
            middelPole.putDown(linkerPole.pickUp());
            printPoles();
        }
        public void printPoles()
        {
            linkerPole.printPole();
            middelPole.printPole();
            rechterPole.printPole();
        }
    }
}
