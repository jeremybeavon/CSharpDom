namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.ConversionOperators
{
    public class ClassWithNestedAbstractPartialClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup
    {
        public abstract partial class Class
        {
            [Attribute1, Attribute2]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
