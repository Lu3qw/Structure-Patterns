using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _008_Iterator
{
    internal class Bank : IEnumerable
    {
        List<Banknote> bankVault = new List<Banknote> 
        { 
            new Banknote(), new Banknote(), new Banknote(), new Banknote()
        };

        public int Count
        {
            get { return bankVault.Count; }
        }

        public IEnumerator GetEnumerator()
        {
            return new Cashier(this);
        }


        private class Cashier : IEnumerator
        {
            private Bank bank;

            public Cashier(Bank enumerable)
            {
                this.bank = enumerable;
            }

            private int current = -1;

            public object Current => bank.bankVault[current];

            public bool MoveNext()
            {
                if (current < bank.Count - 1)
                {
                    current++;
                    return true;
                }
                return false;   
            }

            public void Reset()
            {
                current = -1;
            }
        }

    }
}
