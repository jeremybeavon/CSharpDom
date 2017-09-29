namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.ConversionOperators
{
    public partial struct PartialStructWithNestedAbstractClassWithExplicitConversionOperator
    {
        public abstract class Class
        {
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
