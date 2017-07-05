namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.ConversionOperators
{
    public static class StaticClassWithNestedPartialClassWithExplicitConversionOperatorWith1ReturnAttribute
    {
        public partial class Class
        {
            [return: Attribute1]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
