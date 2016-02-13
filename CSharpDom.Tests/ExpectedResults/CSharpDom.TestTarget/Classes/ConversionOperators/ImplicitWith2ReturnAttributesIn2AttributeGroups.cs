namespace CSharpDom.TestTarget.Classes.ConversionOperators
{
    public class ClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups
    {
        [return: Attribute1]
        [return: Attribute2]
        public static implicit operator ClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups(string text)
        {
            return default(ClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups);
        }
    }
}
