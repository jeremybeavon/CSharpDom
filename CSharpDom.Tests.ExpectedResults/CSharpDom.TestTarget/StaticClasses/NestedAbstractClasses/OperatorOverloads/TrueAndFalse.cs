namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.OperatorOverloads
{
    public static class StaticClassWithNestedAbstractClassWithTrueAndFalseOperatorOverloads
    {
        public abstract class Class
        {
            public static bool operator true(Class parameter1)
            {
                return default(bool);
            }

            public static bool operator false(Class parameter1)
            {
                return default(bool);
            }
        }
    }
}
