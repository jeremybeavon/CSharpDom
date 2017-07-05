namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.ConversionOperators
{
    public class ClassWithNestedPartialClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups
    {
        public partial class Class
        {
            [return: Attribute1]
            [return: Attribute2]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
