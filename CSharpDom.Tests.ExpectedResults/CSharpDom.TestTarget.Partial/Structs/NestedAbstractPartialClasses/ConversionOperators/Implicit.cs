namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.ConversionOperators
{
    public struct StructWithNestedAbstractPartialClassWithImplicitConversionOperator
    {
        public abstract partial class Class
        {
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
