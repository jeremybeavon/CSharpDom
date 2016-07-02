namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.ConversionOperators
{
    public struct StructWithNestedAbstractClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup
    {
        public abstract class Class
        {
            [Attribute1, Attribute2]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
