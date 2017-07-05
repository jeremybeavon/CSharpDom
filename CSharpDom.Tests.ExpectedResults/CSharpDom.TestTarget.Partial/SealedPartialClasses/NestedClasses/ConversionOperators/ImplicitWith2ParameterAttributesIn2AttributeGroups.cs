namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithNestedClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups
    {
        public class Class
        {
            public static implicit operator Class([Attribute1][Attribute2]string text)
            {
                return default(Class);
            }
        }
    }
}
