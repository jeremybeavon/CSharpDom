namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.ConversionOperators
{
    public partial struct PartialStructWithWithNestedAbstractClassWithImplicitConversionOperator
    {
        public abstract class Class
        {
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
