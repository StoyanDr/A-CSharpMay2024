﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsandComparators;

public class Book : IComparable<Book>
{
    
    public string Title { get; set; }
    public int Year { get; set; }
    public List<string> Authors { get; set; }
    public Book(string title, int year, params string[] authors)
    {
        Title = title;
        Year = year;
        Authors = authors.ToList();
    }

    public int CompareTo(Book other)
    {
        if(this.Year - other.Year != 0) return this.Year - other.Year;
        return this.Title.CompareTo(other.Title);
    }
}
