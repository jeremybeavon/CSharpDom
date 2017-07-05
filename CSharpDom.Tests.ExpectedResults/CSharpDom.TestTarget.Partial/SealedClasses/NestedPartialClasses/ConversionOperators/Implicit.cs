namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.ConversionOperators
{
    public sealed class SealedClassWithNestedPartialClassWithImplicitConversionOperator
    {
        public partial class Class
        {
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
