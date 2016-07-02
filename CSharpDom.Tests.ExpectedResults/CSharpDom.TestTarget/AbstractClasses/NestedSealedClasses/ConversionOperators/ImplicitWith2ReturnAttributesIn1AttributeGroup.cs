namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.ConversionOperators
{
    public abstract class AbstractClassWithNestedSealedClassWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            [return: Attribute1, Attribute2]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
