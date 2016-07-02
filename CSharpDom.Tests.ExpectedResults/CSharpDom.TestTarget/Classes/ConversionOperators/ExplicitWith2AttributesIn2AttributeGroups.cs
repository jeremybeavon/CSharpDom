namespace CSharpDom.TestTarget.Classes.ConversionOperators
{
    public class ClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups
    {
        [Attribute1]
        [Attribute2]
        public static explicit operator ClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups(string text)
        {
            return default(ClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups);
        }
    }
}
