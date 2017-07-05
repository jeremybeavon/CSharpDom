namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.ConversionOperators
{
    public sealed class SealedClassWithNestedPartialClassWithExplicitConversionOperatorWith1ParameterAttribute
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
