namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.ConversionOperators
{
    public static partial class StaticPartialClassWithNestedClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup
    {
        public class Class
        {
            public static explicit operator Class([Attribute1, Attribute2]string text)
            {
                return default(Class);
            }
        }
    }
}
