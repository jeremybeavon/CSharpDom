namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithExplicitConversionOperatorWith1ReturnAttribute
    {
        public sealed class Class
        {
            [return: Attribute1]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
