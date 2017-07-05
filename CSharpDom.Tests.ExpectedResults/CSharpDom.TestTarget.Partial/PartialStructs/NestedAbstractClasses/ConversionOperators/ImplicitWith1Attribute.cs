namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.ConversionOperators
{
    public partial struct PartialStructWithWithNestedAbstractClassWithImplicitConversionOperatorWith1Attribute
    {
        public abstract class Class
        {
            [Attribute1]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
