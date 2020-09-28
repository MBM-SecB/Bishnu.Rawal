using System;
public class Country
{
    public string Name { get; set; }
    public string Capitol { get; set; }
    public string Continent { get; set; }
    public long Population { get; set; }
    public DateTime IndependenceDay { get; set; }

    public Country(string n, string cp, string c, long p, DateTime i = default)
    {
        Name = n;
        Capitol = cp;
        Continent = c;
        Population = p;
        IndependenceDay = i;
    }
}