namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.ConversionOperators
{
    public partial class PartialClassWithNestedAbstractClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup
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
