namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.ConversionOperators
{
    public class ClassWithNestedPartialClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups
    {
        public partial class Class
        {
            public static explicit operator Class([Attribute1][Attribute2]string text)
            {
                return default(Class);
            }
        }
    }
}
