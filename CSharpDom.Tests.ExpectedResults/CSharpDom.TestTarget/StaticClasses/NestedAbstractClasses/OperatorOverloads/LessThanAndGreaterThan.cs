namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.OperatorOverloads
{
    public static class StaticClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloads
    {
        public abstract class Class
        {
            public static bool operator <(Class parameter1, Class parameter2)
            {
                return default(bool);
            }

            public static bool operator >(Class parameter1, Class parameter2)
            {
                return default(bool);
            }
        }
    }
}
