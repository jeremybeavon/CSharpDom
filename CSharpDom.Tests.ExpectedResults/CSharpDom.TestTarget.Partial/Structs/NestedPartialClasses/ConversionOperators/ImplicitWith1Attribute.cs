namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.ConversionOperators
{
    public struct StructWithNestedPartialClassWithImplicitConversionOperatorWith1Attribute
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
