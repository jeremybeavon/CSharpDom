namespace CSharpDom.TestTarget.Classes.ConversionOperators
{
    public class ClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup
    {
        [Attribute1, Attribute2]
        public static implicit operator ClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup(string text)
        {
            return default(ClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup);
        }
    }
}
