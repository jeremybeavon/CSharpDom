namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithImplicitConversionOperator
    {
        public abstract class Class
        {
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
