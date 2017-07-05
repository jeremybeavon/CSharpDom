namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.OperatorOverloads
{
    public static class StaticClassWithNestedAbstractPartialClassWithMinusOperatorOverload
    {
        public abstract partial class Class
        {
            public static Class operator -(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
