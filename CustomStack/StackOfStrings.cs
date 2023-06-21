using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {


        public bool IsEmpty()
        {
            if (this.Count == 0)
            {
                return true;
            }
            else { return false; }
        }
        public void AddRange(IEnumerable<string> words)
        {
            foreach (var word in words)
            {
               this.Push(word);
            }
        }
    }
}
