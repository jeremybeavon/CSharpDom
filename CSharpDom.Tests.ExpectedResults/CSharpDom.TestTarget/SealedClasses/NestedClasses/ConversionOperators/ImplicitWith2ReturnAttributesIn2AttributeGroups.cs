namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.ConversionOperators
{
    public sealed class SealedClassWithNestedClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups
    {
        public class Class
        {
            [return: Attribute1]
            [return: Attribute2]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
