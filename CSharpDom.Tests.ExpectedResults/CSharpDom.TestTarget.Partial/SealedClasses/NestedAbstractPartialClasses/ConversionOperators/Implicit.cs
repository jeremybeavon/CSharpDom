namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.ConversionOperators
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithImplicitConversionOperator
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
