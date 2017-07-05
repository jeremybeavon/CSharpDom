namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.ConversionOperators
{
    public static class StaticClassWithNestedSealedPartialClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups
    {
        public sealed partial class Class
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
