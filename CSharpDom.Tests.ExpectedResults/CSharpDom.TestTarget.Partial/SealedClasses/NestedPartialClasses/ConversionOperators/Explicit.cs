namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.ConversionOperators
{
    public sealed class SealedClassWithNestedPartialClassWithExplicitConversionOperator
    {
        public partial class Class
        {
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
