namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups
    {
        public abstract class Class
        {
            public static implicit operator Class([Attribute1][Attribute2]string text)
            {
                return default(Class);
            }
        }
    }
}
