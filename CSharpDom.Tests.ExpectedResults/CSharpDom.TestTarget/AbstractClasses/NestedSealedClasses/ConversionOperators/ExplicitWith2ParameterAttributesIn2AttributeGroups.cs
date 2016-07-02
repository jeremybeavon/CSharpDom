namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.ConversionOperators
{
    public abstract class AbstractClassWithNestedSealedClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            public static explicit operator Class([Attribute1][Attribute2]string text)
            {
                return default(Class);
            }
        }
    }
}
