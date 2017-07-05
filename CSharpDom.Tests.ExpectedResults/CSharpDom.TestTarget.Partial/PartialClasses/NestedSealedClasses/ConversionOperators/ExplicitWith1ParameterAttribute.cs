namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.ConversionOperators
{
    public partial class PartialClassWithNestedSealedClassWithExplicitConversionOperatorWith1ParameterAttribute
    {
        public sealed class Class
        {
            public static explicit operator Class([Attribute1]string text)
            {
                return default(Class);
            }
        }
    }
}
