namespace CSharpDom.TestTarget.AbstractClasses.ConversionOperators
{
    public abstract class AbstractClassWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup
    {
        [return: Attribute1, Attribute2]
        public static implicit operator AbstractClassWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup(string text)
        {
            return default(AbstractClassWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup);
        }
    }
}
