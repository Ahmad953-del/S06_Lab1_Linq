namespace LinqEtSeedEF.Models
{
    public class TestData
    {
        public TestData() { }

        public TestData(int valeurA, int valeurB) {
            ValeurA = valeurA;
            ValeurB = valeurB;
        }

        public int Id { get; set; }
        public int ValeurA { get; set; }
        public int ValeurB { get; set; }
    }
}
