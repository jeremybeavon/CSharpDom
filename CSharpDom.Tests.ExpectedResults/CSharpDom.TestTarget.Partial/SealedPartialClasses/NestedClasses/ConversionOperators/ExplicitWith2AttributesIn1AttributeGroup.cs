namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithNestedClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup
    {
        public class Class
        {
            [Attribute1, Attribute2]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
