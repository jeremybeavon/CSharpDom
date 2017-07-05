namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.ConversionOperators
{
    public struct StructWithNestedSealedPartialClassWithImplicitConversionOperatorWith1Attribute
    {
        public sealed partial class Class
        {
            [Attribute1]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
