namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.ConversionOperators
{
    public sealed class SealedClassWithNestedSealedClassWithExplicitConversionOperator
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
