namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup
    {
        public abstract class Class
        {
            [Attribute1, Attribute2]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
