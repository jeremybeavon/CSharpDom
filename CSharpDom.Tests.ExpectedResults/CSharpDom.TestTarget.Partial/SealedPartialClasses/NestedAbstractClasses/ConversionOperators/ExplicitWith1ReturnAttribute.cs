namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithExplicitConversionOperatorWith1ReturnAttribute
    {
        public abstract class Class
        {
            [return: Attribute1]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
