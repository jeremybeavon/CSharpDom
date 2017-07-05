namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.ConversionOperators
{
    public static class StaticClassWithNestedAbstractPartialClassWithExplicitConversionOperator
    {
        public abstract partial class Class
        {
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
