using System.Collections;
using System.Collections.Generic;

namespace PracticeIterators;

internal class Alphabet : IEnumerable<char>
{
    private List<char> _letters = new List<char>();

    public Alphabet()
    {
        for (char ch = 'A'; ch <= 'Z'; ch++)
        {
            _letters.Add(ch);
        }
    }

    public IEnumerator<char> GetEnumerator()
    {
        foreach (char letter in _letters)
        {
            yield return letter;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}