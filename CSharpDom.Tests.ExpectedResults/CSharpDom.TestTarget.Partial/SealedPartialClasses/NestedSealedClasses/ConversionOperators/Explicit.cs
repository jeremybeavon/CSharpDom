namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithExplicitConversionOperator
    {
        public sealed class Class
        {
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
