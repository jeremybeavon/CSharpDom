namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.ConversionOperators
{
    public abstract class AbstractClassWithNestedPartialClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups
    {
        public partial class Class
        {
            public static implicit operator Class([Attribute1][Attribute2]string text)
            {
                return default(Class);
            }
        }
    }
}
