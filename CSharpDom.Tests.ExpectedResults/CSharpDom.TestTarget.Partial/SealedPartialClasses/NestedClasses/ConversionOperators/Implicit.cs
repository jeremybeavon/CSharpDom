namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithNestedClassWithImplicitConversionOperator
    {
        public class Class
        {
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
