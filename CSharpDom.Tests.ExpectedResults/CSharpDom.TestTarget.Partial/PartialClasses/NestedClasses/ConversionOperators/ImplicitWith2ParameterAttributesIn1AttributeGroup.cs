namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.ConversionOperators
{
    public partial class PartialClassWithNestedClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup
    {
        public class Class
        {
            public static implicit operator Class([Attribute1, Attribute2]string text)
            {
                return default(Class);
            }
        }
    }
}
