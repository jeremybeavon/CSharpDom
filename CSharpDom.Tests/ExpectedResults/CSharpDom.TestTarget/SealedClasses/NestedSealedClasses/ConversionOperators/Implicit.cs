namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.ConversionOperators
{
    public sealed class SealedClassWithNestedSealedClassWithImplicitConversionOperator
    {
        public sealed class Class
        {
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
