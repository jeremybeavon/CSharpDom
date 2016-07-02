namespace CSharpDom.TestTarget.Classes.ConversionOperators
{
    public class ClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups
    {
        [return: Attribute1]
        [return: Attribute2]
        public static explicit operator ClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups(string text)
        {
            return default(ClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups);
        }
    }
}
