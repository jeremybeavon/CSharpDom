namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups
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
