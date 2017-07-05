namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.ConversionOperators
{
    public static class StaticClassWithNestedAbstractPartialClassWithExplicitConversionOperatorWith1Attribute
    {
        public abstract partial class Class
        {
            [Attribute1]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
