using System;
using System.Collections;
using System.Collections.Generic;

namespace PracticeIterators;

internal class House : IEnumerable<Apartment>
{
    private List<Apartment> _apartments = new List<Apartment>();

    public string Address { get; set; } = string.Empty;

    public House(string address)
    {
        Address = address;
    }

    public void AddApartment(Apartment apartment)
    {
        if (apartment == null)
        {
            throw new ArgumentNullException("Apartment cannot be null");
        }
        _apartments.Add(apartment);
    }

    public IEnumerator<Apartment> GetEnumerator()
    {
        foreach (Apartment apartment in _apartments)
        {
            yield return apartment;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}