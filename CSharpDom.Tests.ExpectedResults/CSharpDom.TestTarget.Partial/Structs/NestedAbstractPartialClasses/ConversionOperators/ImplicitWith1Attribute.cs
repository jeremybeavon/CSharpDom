namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.ConversionOperators
{
    public struct StructWithNestedAbstractPartialClassWithImplicitConversionOperatorWith1Attribute
    {
        public abstract partial class Class
        {
            [Attribute1]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
