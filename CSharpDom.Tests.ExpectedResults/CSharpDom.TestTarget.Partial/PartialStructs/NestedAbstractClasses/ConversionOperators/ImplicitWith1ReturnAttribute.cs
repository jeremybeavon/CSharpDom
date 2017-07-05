namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.ConversionOperators
{
    public partial struct PartialStructWithWithNestedAbstractClassWithImplicitConversionOperatorWith1ReturnAttribute
    {
        public abstract class Class
        {
            [return: Attribute1]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
