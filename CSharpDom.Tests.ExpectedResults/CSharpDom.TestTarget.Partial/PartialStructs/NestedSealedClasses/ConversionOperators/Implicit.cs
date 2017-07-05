namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.ConversionOperators
{
    public partial struct PartialStructWithWithNestedSealedClassWithImplicitConversionOperator
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
