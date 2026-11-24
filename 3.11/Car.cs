using System;

namespace PracticeIterators;

internal class Car
{
    private string _brand = string.Empty;
    private string _model = string.Empty;
    private int _year;

    public string Brand
    {
        get
        {
            return _brand;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid brand");
            }
            _brand = value;
        }
    }

    public string Model
    {
        get
        {
            return _model;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid model");
            }
            _model = value;
        }
    }

    public int Year
    {
        get
        {
            return _year;
        }
        set
        {
            if (value < 1886 || value > 2026)
            {
                throw new ArgumentOutOfRangeException("Invalid year");
            }
            _year = value;
        }
    }

    public Car(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    public override string ToString()
    {
        return $"{Brand} {Model} ({Year})";
    }
}