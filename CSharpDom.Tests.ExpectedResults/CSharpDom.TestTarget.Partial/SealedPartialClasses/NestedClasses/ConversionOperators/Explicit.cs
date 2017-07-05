namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithNestedClassWithExplicitConversionOperator
    {
        public class Class
        {
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
