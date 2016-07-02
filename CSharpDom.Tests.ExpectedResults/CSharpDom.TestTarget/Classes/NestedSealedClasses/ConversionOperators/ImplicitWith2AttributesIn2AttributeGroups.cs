namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.ConversionOperators
{
    public class ClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            [Attribute1]
            [Attribute2]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
