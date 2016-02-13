namespace CSharpDom.TestTarget.Classes.ConversionOperators
{
    public class ClassWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup
    {
        [return: Attribute1, Attribute2]
        public static implicit operator ClassWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup(string text)
        {
            return default(ClassWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup);
        }
    }
}
