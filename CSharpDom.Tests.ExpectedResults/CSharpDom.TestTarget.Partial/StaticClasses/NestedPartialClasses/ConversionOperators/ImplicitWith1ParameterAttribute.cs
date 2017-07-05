namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.ConversionOperators
{
    public static class StaticClassWithNestedPartialClassWithImplicitConversionOperatorWith1ParameterAttribute
    {
        public partial class Class
        {
            public static implicit operator Class([Attribute1]string text)
            {
                return default(Class);
            }
        }
    }
}
