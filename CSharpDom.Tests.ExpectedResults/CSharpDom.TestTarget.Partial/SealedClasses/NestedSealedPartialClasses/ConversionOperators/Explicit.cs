namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.ConversionOperators
{
    public sealed class SealedClassWithNestedSealedPartialClassWithExplicitConversionOperator
    {
        public sealed partial class Class
        {
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
