namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.ConversionOperators
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithExplicitConversionOperator
    {
        public abstract partial class Class
        {
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
