namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.ConversionOperators
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithImplicitConversionOperator
    {
        public abstract partial class Class
        {
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
