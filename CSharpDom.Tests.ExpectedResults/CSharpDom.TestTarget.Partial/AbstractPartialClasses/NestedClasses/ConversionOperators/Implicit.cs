namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithNestedClassWithImplicitConversionOperator
    {
        public class Class
        {
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
