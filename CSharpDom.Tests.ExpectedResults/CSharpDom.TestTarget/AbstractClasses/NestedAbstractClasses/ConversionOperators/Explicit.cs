namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.ConversionOperators
{
    public abstract class AbstractClassWithNestedAbstractClassWithExplicitConversionOperator
    {
        public abstract class Class
        {
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
