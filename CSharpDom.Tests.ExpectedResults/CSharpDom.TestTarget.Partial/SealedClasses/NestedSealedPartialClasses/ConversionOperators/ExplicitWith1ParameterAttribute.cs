namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.ConversionOperators
{
    public sealed class SealedClassWithNestedSealedPartialClassWithExplicitConversionOperatorWith1ParameterAttribute
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
