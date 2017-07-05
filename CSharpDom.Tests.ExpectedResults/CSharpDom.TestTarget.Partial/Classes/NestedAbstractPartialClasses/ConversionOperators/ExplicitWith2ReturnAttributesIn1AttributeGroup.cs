namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.ConversionOperators
{
    public class ClassWithNestedAbstractPartialClassWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup
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
