namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.ConversionOperators
{
    public abstract class AbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith1ParameterAttribute
    {
        public abstract class Class
        {
            public static explicit operator Class([Attribute1]string text)
            {
                return default(Class);
            }
        }
    }
}
