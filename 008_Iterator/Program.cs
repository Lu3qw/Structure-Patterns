// Ітератор

using _008_Iterator;
using System.Collections;

IEnumerable bank = new Bank();

// IEnumerator cashier = bank.GetEnumerator();

foreach (Banknote banknote in bank)
{
    Console.WriteLine(banknote?.Nominal);
}