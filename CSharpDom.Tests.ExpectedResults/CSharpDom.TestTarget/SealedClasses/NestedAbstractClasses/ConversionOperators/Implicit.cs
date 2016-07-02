namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.ConversionOperators
{
    public sealed class SealedClassWithNestedAbstractClassWithImplicitConversionOperator
    {
        public abstract class Class
        {
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
