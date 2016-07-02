namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.ConversionOperators
{
    public class ClassWithNestedAbstractClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup
    {
        public abstract class Class
        {
            [Attribute1, Attribute2]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
