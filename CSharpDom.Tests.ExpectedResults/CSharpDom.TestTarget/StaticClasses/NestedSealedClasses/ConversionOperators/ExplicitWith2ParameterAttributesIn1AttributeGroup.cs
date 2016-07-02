namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.ConversionOperators
{
    public static class StaticClassWithNestedSealedClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            public static explicit operator Class([Attribute1, Attribute2]string text)
            {
                return default(Class);
            }
        }
    }
}
