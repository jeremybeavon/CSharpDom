namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.ConversionOperators
{
    public abstract class AbstractClassWithNestedClassWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup
    {
        public class Class
        {
            [return: Attribute1, Attribute2]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
