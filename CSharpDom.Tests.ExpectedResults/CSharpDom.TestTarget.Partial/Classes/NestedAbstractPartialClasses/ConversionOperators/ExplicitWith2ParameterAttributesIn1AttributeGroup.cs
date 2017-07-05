namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.ConversionOperators
{
    public class ClassWithNestedAbstractPartialClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup
    {
        public abstract partial class Class
        {
            public static explicit operator Class([Attribute1, Attribute2]string text)
            {
                return default(Class);
            }
        }
    }
}
