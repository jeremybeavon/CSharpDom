namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.ConversionOperators
{
    public sealed class SealedClassWithNestedAbstractClassWithExplicitConversionOperator
    {
        public abstract class Class
        {
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
