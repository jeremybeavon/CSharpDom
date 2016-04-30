namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.OperatorOverloads
{
    public abstract class AbstractClassWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads
    {
        public abstract class Class
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
