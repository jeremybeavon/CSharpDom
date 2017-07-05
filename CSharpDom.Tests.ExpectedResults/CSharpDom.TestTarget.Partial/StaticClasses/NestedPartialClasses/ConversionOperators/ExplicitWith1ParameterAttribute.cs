namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.ConversionOperators
{
    public static class StaticClassWithNestedPartialClassWithExplicitConversionOperatorWith1ParameterAttribute
    {
        public partial class Class
        {
            public static explicit operator Class([Attribute1]string text)
            {
                return default(Class);
            }
        }
    }
}
