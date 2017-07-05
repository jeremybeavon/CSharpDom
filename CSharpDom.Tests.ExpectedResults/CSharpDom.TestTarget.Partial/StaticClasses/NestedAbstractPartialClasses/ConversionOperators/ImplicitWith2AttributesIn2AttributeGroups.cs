namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.ConversionOperators
{
    public static class StaticClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups
    {
        public abstract partial class Class
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
