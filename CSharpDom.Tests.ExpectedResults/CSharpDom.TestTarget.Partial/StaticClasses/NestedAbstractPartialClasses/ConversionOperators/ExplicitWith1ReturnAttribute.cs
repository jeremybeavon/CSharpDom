namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.ConversionOperators
{
    public static class StaticClassWithNestedAbstractPartialClassWithExplicitConversionOperatorWith1ReturnAttribute
    {
        public abstract partial class Class
        {
            [return: Attribute1]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
