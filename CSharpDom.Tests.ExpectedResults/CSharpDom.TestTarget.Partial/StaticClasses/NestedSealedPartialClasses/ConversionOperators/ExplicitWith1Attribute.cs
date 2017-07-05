namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.ConversionOperators
{
    public static class StaticClassWithNestedSealedPartialClassWithExplicitConversionOperatorWith1Attribute
    {
        public sealed partial class Class
        {
            [Attribute1]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
