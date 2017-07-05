namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.ConversionOperators
{
    public static class StaticClassWithNestedAbstractPartialClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups
    {
        public abstract partial class Class
        {
            [return: Attribute1]
            [return: Attribute2]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
