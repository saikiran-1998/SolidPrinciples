namespace LiskovSubstitution
{
    internal class PermanentEmployee : Employee
    {
        public PermanentEmployee(int id, string name) : base(id, name)
        {
        }

        public override double CalculateBonus(double salary)
        {
            return salary+20000;
        }

        public override double GetMinimumSalary()
        {
            return 15000;
        }
    }
}
