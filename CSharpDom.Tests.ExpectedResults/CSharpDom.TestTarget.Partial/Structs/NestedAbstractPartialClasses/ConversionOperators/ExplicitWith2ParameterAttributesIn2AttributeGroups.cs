namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.ConversionOperators
{
    public struct StructWithNestedAbstractPartialClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups
    {
        public abstract partial class Class
        {
            public static explicit operator Class([Attribute1][Attribute2]string text)
            {
                return default(Class);
            }
        }
    }
}
