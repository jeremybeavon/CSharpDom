namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.ConversionOperators
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup
    {
        public abstract class Class
        {
            public static implicit operator Class([Attribute1, Attribute2]string text)
            {
                return default(Class);
            }
        }
    }
}
