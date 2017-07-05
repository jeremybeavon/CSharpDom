namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.OperatorOverloads
{
    public static class StaticClassWithNestedAbstractPartialClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads
    {
        public abstract partial class Class
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
