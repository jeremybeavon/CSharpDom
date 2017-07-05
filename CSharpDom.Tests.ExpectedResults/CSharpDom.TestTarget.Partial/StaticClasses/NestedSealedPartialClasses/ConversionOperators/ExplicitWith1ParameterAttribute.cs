namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.ConversionOperators
{
    public static class StaticClassWithNestedSealedPartialClassWithExplicitConversionOperatorWith1ParameterAttribute
    {
        public sealed partial class Class
        {
            public static explicit operator Class([Attribute1]string text)
            {
                return default(Class);
            }
        }
    }
}
