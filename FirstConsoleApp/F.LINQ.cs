// LINQ- Language Integrated Query 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates; //where is inthis namespace // link contained classes 

class LINQLearner
{
    void Learn()
    {
    int[] numbers =  [3,4,5,67,12,34,56,78,89,98,123];
    List<string> names = ["Anjali", "Anisha", "Priyanka", "Rekha", "Prashuva"];

    var s1= new Student("Anjali", 11, new DateTime(2002, 1, 23));
    var s2= new Student("Anisha", 5, new DateTime(2003, 2, 12));
    var s3= new Student("Priyanka", 7, new DateTime(2002, 11, 12));
    var s4= new Student("Rekha", 8, new DateTime(2001, 8, 22));
    var s5= new Student("Prashuva", 23, new DateTime(2000, 12, 15));

    List<Student> students = [s1, s2, s3, s4, s5];

    //Get odd numbers from "numbers"
    var oddNumbers = numbers.Where(number => number % 2 == 1); //Lambda Expression
    
    //Get squares of all items in "numbers"  
    var squares = numbers.Select(x => x*x);  //Projection operator

    //Get squares of even numbers only
    //Method Syntax
    var evenSquares =  numbers.Where(number => number % 2 == 0).Select(y => y*y); //where-filter  //select-projects
    
    //Query Syntax
    evenSquares =  from x in numbers
                   where x % 2 == 0
                   select x * x;

    //Get all name initials 
    var initials = names.Select(name => name[0]); //0th position of name - initial //{'A','A','P','R'}
    
    //Order names in ascending order 
    var namesOrdered = names.OrderBy(x => x);  //OrderBy- List 

    //Find students with name starting with "A"
    var aStudents = students.Where(student => student.name.ToUpper().StartsWith('A'));
    
    //Group students by birth month
    var birthMonth = students.GroupBy(student => student.Dob.Month);

    //Get youngest student 
    var youngestStudent = students.OrderByDescending(x => x.Dob).First();
    youngestStudent = students.MaxBy(x => x.Dob);

    

    }
}