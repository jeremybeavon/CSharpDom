namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.ConversionOperators
{
    public abstract class AbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups
    {
        public abstract class Class
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
