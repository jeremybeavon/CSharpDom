namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.ConversionOperators
{
    public partial class PartialClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups
    {
        public abstract class Class
        {
            public static explicit operator Class([Attribute1][Attribute2]string text)
            {
                return default(Class);
            }
        }
    }
}
