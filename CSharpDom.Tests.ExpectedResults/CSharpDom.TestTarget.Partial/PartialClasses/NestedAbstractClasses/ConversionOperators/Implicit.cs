namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.ConversionOperators
{
    public partial class PartialClassWithNestedAbstractClassWithImplicitConversionOperator
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
