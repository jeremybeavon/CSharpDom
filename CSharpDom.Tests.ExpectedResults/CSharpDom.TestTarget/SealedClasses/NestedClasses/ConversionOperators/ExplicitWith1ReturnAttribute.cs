namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.ConversionOperators
{
    public sealed class SealedClassWithNestedClassWithExplicitConversionOperatorWith1ReturnAttribute
    {
        public class Class
        {
            [return: Attribute1]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
