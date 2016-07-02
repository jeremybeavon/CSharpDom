namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.ConversionOperators
{
    public abstract class AbstractClassWithNestedSealedClassWithExplicitConversionOperatorWith1ReturnAttribute
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
