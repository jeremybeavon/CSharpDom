namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.ConversionOperators
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup
    {
        public sealed partial class Class
        {
            [Attribute1, Attribute2]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
