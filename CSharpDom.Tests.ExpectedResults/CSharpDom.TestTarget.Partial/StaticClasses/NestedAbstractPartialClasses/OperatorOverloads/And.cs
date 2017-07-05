namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.OperatorOverloads
{
    public static class StaticClassWithNestedAbstractPartialClassWithAndOperatorOverload
    {
        public abstract partial class Class
        {
            public static Class operator &(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
