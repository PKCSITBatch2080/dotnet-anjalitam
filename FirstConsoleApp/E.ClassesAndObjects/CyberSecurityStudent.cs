using System;
using System.Reflection.Metadata;

class CyberSecurityStudent: CSStudent
{

public CyberSecurityStudent(string name, byte rn, string pTitle, string certification) //ctor
    : base(name, rn, pTitle)   
    { 
      SecurityCertification  = certification;  //base keyword
    }

    public string EthicalHackingCourseTitle{ get; set;}
    public string SecurityCertification{ get; set;}
    public DateTime CertifiedDate{ get; set;}
    
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Certification: {SecurityCertification}");
        Console.WriteLine($"Certified Date: {CertifiedDate}");
    } 
}
