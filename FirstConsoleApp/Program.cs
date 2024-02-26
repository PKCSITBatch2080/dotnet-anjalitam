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
 
Generics g = new();
g.Display<string>("jshflsff");
g.Display<int>(786);

Student anjali= new Student();
Student anisha= new Student("anisha nayaju", 5);
anisha.RollNumber = 223; //Not assigned
anjali.RollNumber = 22; //Assigned




