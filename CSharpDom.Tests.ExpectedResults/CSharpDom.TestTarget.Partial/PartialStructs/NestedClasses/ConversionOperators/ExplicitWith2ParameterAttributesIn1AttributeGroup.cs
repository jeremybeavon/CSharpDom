namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.ConversionOperators
{
    public partial struct PartialStructWithWithNestedClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup
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
