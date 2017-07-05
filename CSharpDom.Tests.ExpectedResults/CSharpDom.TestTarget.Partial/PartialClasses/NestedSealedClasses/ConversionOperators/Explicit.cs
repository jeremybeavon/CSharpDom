namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.ConversionOperators
{
    public partial class PartialClassWithNestedSealedClassWithExplicitConversionOperator
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
