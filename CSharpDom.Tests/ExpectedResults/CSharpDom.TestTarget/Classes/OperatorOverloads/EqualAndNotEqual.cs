namespace CSharpDom.TestTarget.Classes.OperatorOverloads
{
    public class ClassWithEqualAndNotEqualOperatorOverloads
    {
        public static bool operator ==(ClassWithEqualAndNotEqualOperatorOverloads parameter1, ClassWithEqualAndNotEqualOperatorOverloads parameter2)
        {
            return default(bool);
        }

        public static bool operator !=(ClassWithEqualAndNotEqualOperatorOverloads parameter1, ClassWithEqualAndNotEqualOperatorOverloads parameter2)
        {
            return default(bool);
        }
    }
}
