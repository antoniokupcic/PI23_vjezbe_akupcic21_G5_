using Evaluation_Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationManager.Models {
  
    public string K2 MyProperty { get; set; }

    public string HasSignature { get; set; }
    public int HasGrade { get; set; }
    public int TotalPoints { get; set; }
    public int Grade { get; set; }

public class StudentReportView (Student student){
    FirstName = student.FirstName:
    LastName = student.LastName;

    hasSignature = Student.HasSignature() == true ? "Da" : "Ne";
    HasGrade = Student.HasGrade() == true ? "Da" : "Ne";
    Grade = Student.CalculateGrade();

    var evaluations = Student.GetEvaluations();


 // napiši doma
}
    
}

