namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.ConversionOperators
{
    public abstract class AbstractClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups
    {
        public abstract class Class
        {
            public static implicit operator Class([Attribute1][Attribute2]string text)
            {
                return default(Class);
            }
        }
    }
}
