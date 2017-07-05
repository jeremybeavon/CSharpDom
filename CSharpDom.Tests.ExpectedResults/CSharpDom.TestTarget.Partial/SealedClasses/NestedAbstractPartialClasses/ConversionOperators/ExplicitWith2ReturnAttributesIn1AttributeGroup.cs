namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.ConversionOperators
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup
    {
        public abstract partial class Class
        {
            [return: Attribute1, Attribute2]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
