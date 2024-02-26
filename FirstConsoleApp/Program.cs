using System;

Console.WriteLine("I am main method");

DataTypes dt = new();
dt.Learn();


Methods m = new();
m.Greet("Hi");
m.CalculateBMI(233.3f, 343.34f);

var highest = m.GetMax(3.4, 5.6, 78.4, 23.4); //using without array
var highest2 = m.GetMax(3.4, 5.6);
var highest3 = m.GetMax(3.4, 5.6, 78.4, 23.4, 67.8);
var highest4 = m.GetMax(5.6,  23.4);
 
Console.WriteLine(highest);