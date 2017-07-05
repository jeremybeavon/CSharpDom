namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.ConversionOperators
{
    public static class StaticClassWithNestedPartialClassWithImplicitConversionOperatorWith1Attribute
    {
        public partial class Class
        {
            [Attribute1]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
