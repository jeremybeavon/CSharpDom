namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.OperatorOverloads
{
    public abstract class AbstractClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads
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
