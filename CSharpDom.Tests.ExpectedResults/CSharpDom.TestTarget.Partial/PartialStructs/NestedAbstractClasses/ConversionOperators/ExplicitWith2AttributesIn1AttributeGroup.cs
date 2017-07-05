namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.ConversionOperators
{
    public partial struct PartialStructWithWithNestedAbstractClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup
    {
        public abstract class Class
        {
            [Attribute1, Attribute2]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
