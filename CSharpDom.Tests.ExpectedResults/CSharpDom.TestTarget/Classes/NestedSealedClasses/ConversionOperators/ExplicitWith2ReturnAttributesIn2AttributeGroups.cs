namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.ConversionOperators
{
    public class ClassWithNestedSealedClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            [return: Attribute1]
            [return: Attribute2]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
