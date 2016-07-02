namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.ConversionOperators
{
    public sealed class SealedClassWithNestedClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup
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
