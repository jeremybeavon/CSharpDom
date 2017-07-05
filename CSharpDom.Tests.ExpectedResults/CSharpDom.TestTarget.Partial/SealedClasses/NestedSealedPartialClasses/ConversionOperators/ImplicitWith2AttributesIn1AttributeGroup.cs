namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.ConversionOperators
{
    public sealed class SealedClassWithNestedSealedPartialClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup
    {
        public sealed partial class Class
        {
            [Attribute1, Attribute2]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
