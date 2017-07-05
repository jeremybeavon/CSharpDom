namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.ConversionOperators
{
    public sealed class SealedClassWithNestedPartialClassWithImplicitConversionOperatorWith1Attribute
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
