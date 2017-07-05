namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.ConversionOperators
{
    public partial class PartialClassWithNestedSealedClassWithImplicitConversionOperatorWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
