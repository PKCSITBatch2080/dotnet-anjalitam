using System;
 class Student
 {
    //default constructor
    
    public Student()
    {

    }
    //Parameterized  constructor
     public Student(string n, byte rn)
    {
    name=n;
    RollNumber= rn;
    }
     public Student(string n, byte rn, DateTime dob)
    {
    name=n;
    RollNumber= rn;
    Dob= dob;
    }
    public string name;
    public static string collegeName;
    byte rollNumber;
    public byte RollNumber
    {
        get 
        {
            return rollNumber;
        }
        set
        {
            if(value<=100)
            {
                rollNumber = value;
            }
        }
    }
    public string Address{get; set;} //Auto implemented property
     public DateTime Dob{get;}

      
public virtual void DisplayInfo()
{
    Console.WriteLine($"Student Name:{name}");
    Console.WriteLine($"Student Roll Number:{rollNumber}");
    Console.WriteLine($"Student Dob:{Dob}");
    Console.WriteLine($"Student Date of Address:{Address}");

}
 }