//Single Inheritance
class CSStudent: Student, IGradeable //Multiple Inheritance 
{
    public CSStudent(string name, byte rn, string pTitle) //ctor
    : base(name, rn)   
    { 
      ProjectTitle  = pTitle;  //base keyword
    }
public string ProjectTitle{ get; set;}
public string InternWork{ get; set;}
public double GetGrade() => 3.6;

}