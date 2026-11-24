using System;
using System.Collections;
using System.Collections.Generic;

namespace PracticeIterators;

internal class Garage : IEnumerable<Car>
{
    private List<Car> _cars = new List<Car>();

    public string Name { get; set; } = string.Empty;

    public Garage(string name)
    {
        Name = name;
    }

    public void AddCar(Car car)
    {
        if (car == null)
        {
            throw new ArgumentNullException("Car cannot be null");
        }
        _cars.Add(car);
    }

    public IEnumerator<Car> GetEnumerator()
    {
        foreach (Car car in _cars)
        {
            yield return car;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}