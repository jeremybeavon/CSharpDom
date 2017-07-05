namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.ConversionOperators
{
    public partial struct PartialStructWithWithNestedSealedClassWithImplicitConversionOperatorWith1Attribute
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
