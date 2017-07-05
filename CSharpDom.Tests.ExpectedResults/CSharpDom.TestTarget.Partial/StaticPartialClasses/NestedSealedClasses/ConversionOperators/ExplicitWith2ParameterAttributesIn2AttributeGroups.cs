namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.ConversionOperators
{
    public static partial class StaticPartialClassWithNestedSealedClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups
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
