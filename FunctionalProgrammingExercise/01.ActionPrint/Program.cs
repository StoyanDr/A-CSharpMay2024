﻿using System;

string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

Action<string> print = str => Console.WriteLine(str);

foreach (string line in input)
    print(line);