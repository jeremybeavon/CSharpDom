namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.ConversionOperators
{
    public struct StructWithNestedSealedPartialClassWithImplicitConversionOperatorWith1ReturnAttribute
    {
        public sealed partial class Class
        {
            [return: Attribute1]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
