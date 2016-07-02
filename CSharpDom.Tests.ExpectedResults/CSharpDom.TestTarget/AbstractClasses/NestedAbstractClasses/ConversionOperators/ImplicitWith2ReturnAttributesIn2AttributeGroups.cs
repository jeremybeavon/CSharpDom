namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.ConversionOperators
{
    public abstract class AbstractClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups
    {
        public abstract class Class
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
