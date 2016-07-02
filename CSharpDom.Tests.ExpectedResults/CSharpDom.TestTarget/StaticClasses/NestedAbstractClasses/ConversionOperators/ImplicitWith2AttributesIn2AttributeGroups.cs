namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.ConversionOperators
{
    public static class StaticClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups
    {
        public abstract class Class
        {
            [Attribute1]
            [Attribute2]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
