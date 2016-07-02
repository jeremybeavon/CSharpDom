namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.ConversionOperators
{
    public class ClassWithNestedSealedClassWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            [return: Attribute1, Attribute2]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
