namespace CSharpDom.TestTarget.Classes.OperatorOverloads
{
    public class ClassWithEqualAndNotEqualOperators
    {
        public static bool operator ==(ClassWithEqualAndNotEqualOperators parameter1, ClassWithEqualAndNotEqualOperators parameter2)
        {
            return default(bool);
        }

        public static bool operator !=(ClassWithEqualAndNotEqualOperators parameter1, ClassWithEqualAndNotEqualOperators parameter2)
        {
            return default(bool);
        }
    }
}
