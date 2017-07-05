namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.ConversionOperators
{
    public static class StaticClassWithNestedSealedPartialClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup
    {
        public sealed partial class Class
        {
            [Attribute1, Attribute2]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
