namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.ConversionOperators
{
    public class ClassWithNestedSealedPartialClassWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup
    {
        public sealed partial class Class
        {
            [return: Attribute1, Attribute2]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
