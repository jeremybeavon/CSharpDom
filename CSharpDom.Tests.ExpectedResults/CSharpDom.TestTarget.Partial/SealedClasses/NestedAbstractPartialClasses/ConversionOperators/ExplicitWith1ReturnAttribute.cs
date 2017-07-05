namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.ConversionOperators
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithExplicitConversionOperatorWith1ReturnAttribute
    {
        public abstract partial class Class
        {
            [return: Attribute1]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
