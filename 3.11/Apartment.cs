using System;
using System.Collections;
using System.Collections.Generic;

namespace PracticeIterators;

internal class Apartment : IEnumerable<string>
{
    private int _number;
    private List<string> _residents = new List<string>();

    public int Number
    {
        get
        {
            return _number;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Apartment number must be greater than zero");
            }
            _number = value;
        }
    }

    public Apartment(int number)
    {
        Number = number;
    }

    public void AddResident(string residentName)
    {
        if (string.IsNullOrWhiteSpace(residentName))
        {
            throw new ArgumentException("Invalid resident name");
        }
        _residents.Add(residentName);
    }

    public IEnumerator<string> GetEnumerator()
    {
        foreach (string resident in _residents)
        {
            yield return resident;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public override string ToString()
    {
        return $"Квартира №{Number} (Мешканців: {_residents.Count})";
    }
}