namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.OperatorOverloads
{
    public static class StaticClassWithNestedAbstractPartialClassWithLeftShiftOperatorOverload
    {
        public abstract partial class Class
        {
            public static Class operator <<(Class parameter1, int parameter2)
            {
                return default(Class);
            }
        }
    }
}
