﻿int a = 1;
int b = 6;
int c = 4;
int d = 9;
int e = 8;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write ("Max = ");
Console.WriteLine (max);