namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithNestedClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup
    {
        public class Class
        {
            [Attribute1, Attribute2]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
