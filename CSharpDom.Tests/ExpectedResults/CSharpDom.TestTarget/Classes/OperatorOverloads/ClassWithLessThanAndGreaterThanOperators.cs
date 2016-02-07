namespace CSharpDom.TestTarget.Classes.OperatorOverloads
{
    public class ClassWithLessThanAndGreaterThanOperators
    {
        public static bool operator <(ClassWithLessThanAndGreaterThanOperators parameter1, ClassWithLessThanAndGreaterThanOperators parameter2)
        {
            return default(bool);
        }

        public static bool operator >(ClassWithLessThanAndGreaterThanOperators parameter1, ClassWithLessThanAndGreaterThanOperators parameter2)
        {
            return default(bool);
        }
    }
}
