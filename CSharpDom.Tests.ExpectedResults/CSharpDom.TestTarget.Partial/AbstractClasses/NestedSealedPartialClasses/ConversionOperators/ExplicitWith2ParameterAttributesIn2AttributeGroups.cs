namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.ConversionOperators
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups
    {
        public sealed partial class Class
        {
            public static explicit operator Class([Attribute1][Attribute2]string text)
            {
                return default(Class);
            }
        }
    }
}
