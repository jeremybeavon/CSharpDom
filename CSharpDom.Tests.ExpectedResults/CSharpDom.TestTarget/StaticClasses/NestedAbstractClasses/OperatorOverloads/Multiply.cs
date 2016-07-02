namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.OperatorOverloads
{
    public static class StaticClassWithNestedAbstractClassWithMultiplyOperatorOverload
    {
        public abstract class Class
        {
            public static Class operator *(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
