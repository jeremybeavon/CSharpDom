namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithNestedClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups
    {
        public class Class
        {
            public static explicit operator Class([Attribute1][Attribute2]string text)
            {
                return default(Class);
            }
        }
    }
}
