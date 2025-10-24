namespace FinalExamSimulation_20250904.PartA_Ex_2.Models
{
    public class Postgraduate : Student
    {
        public override string GetGrade(int score)
        {
            return score >= 60 ? "Pass" : "Fail";
        }
    }
}