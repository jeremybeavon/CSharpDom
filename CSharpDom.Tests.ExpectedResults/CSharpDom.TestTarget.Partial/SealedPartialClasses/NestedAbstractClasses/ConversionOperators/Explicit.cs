namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithExplicitConversionOperator
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
