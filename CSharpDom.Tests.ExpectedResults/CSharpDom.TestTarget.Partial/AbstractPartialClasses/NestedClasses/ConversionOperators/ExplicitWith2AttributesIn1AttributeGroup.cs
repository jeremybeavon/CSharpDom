namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithNestedClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup
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
