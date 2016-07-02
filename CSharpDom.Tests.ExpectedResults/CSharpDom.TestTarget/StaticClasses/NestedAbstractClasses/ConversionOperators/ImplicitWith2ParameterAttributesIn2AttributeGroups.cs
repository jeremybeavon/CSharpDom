namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.ConversionOperators
{
    public static class StaticClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups
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
