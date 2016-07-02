namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.ConversionOperators
{
    public static class StaticClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup
    {
        public abstract class Class
        {
            public static explicit operator Class([Attribute1, Attribute2]string text)
            {
                return default(Class);
            }
        }
    }
}
