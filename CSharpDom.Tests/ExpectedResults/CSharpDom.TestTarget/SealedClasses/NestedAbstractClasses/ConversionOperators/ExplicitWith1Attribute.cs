namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.ConversionOperators
{
    public sealed class SealedClassWithNestedAbstractClassWithExplicitConversionOperatorWith1Attribute
    {
        public abstract class Class
        {
            [Attribute1]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
