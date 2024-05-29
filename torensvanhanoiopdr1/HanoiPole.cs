using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace torensvanhanoiopdr1
{
    internal class HanoiPole
    {
        private String name = "";
        private String contentString = "";
        private Stack<HanoiDisc> mainPole = new Stack<HanoiDisc>();
        private Stack<HanoiDisc> auxilaryPole = new Stack<HanoiDisc>();

        public HanoiPole(String set_name)
        {
            name = set_name;
        }

        public void putDown(HanoiDisc disc)
        {
            mainPole.Push(disc);
        }
        public HanoiDisc pickUp()
        {
            return mainPole.Pop();
        }
        public HanoiDisc lookIn()
        {
            return mainPole.Peek();
        }
        public bool isEmpty(Stack<HanoiDisc> stackert)
        {
            if (stackert.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isEmpty()
        {
            if (mainPole.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void printPole()
        {
            while (!isEmpty(mainPole))
            {
                auxilaryPole.Push(mainPole.Pop());
            }
            while (!isEmpty(auxilaryPole))
            {
                mainPole.Push(auxilaryPole.Pop());
                contentString = contentString + mainPole.Peek().getSize() + " ";
            }
            Console.WriteLine("Contents of stack " + name + ": " + contentString);
            contentString = "";
        }
    }
}
