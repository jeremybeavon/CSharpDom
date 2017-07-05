namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.ConversionOperators
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithExplicitConversionOperator
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
