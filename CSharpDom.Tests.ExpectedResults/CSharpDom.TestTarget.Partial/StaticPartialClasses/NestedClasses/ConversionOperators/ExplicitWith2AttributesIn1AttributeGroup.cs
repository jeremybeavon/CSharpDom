namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.ConversionOperators
{
    public static partial class StaticPartialClassWithNestedClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup
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
