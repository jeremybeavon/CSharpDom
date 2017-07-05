namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            [Attribute1, Attribute2]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
