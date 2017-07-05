namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithNestedClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups
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
