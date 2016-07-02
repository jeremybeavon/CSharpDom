namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.ConversionOperators
{
    public abstract class AbstractClassWithNestedClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups
    {
        public class Class
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
