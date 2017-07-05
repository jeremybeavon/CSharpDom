namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.ConversionOperators
{
    public partial class PartialClassWithNestedSealedClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            public static explicit operator Class([Attribute1][Attribute2]string text)
            {
                return default(Class);
            }
        }
    }
}
