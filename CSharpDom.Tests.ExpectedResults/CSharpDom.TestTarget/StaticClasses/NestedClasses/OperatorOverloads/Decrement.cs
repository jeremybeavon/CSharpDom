namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.OperatorOverloads
{
    public static class StaticClassWithNestedClassWithDecrementOperatorOverload
    {
        public class Class
        {
            public static Class operator --(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
