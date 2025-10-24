namespace FinalExamSimulation_20250904.PartA_Ex_2.Models
{
    public class Student
    {
        public string Name { get; set; }
        public virtual string GetGrade(int score)
        {
            return score >= 50 ? "Pass" : "Fail";
        }
    }
}