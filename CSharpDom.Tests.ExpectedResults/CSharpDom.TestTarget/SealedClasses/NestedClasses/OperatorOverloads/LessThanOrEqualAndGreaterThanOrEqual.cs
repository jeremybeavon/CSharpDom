namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.OperatorOverloads
{
    public sealed class SealedClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads
    {
        public class Class
        {
            public static bool operator <=(Class parameter1, Class parameter2)
            {
                return default(bool);
            }

            public static bool operator >=(Class parameter1, Class parameter2)
            {
                return default(bool);
            }
        }
    }
}
