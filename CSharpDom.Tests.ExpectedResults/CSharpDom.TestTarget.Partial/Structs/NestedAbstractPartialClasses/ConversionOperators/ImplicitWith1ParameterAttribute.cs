namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.ConversionOperators
{
    public struct StructWithNestedAbstractPartialClassWithImplicitConversionOperatorWith1ParameterAttribute
    {
        public abstract partial class Class
        {
            public static implicit operator Class([Attribute1]string text)
            {
                return default(Class);
            }
        }
    }
}
