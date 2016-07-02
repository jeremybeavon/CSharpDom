namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.ConversionOperators
{
    public abstract class AbstractClassWithNestedSealedClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            [Attribute1]
            [Attribute2]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
