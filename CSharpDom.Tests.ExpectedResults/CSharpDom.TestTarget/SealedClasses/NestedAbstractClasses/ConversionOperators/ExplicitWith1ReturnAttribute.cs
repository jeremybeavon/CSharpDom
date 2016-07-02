namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.ConversionOperators
{
    public sealed class SealedClassWithNestedAbstractClassWithExplicitConversionOperatorWith1ReturnAttribute
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
