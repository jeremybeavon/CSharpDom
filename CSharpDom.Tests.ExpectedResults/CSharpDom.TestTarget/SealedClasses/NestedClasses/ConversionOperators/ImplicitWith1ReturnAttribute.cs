namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.ConversionOperators
{
    public sealed class SealedClassWithNestedClassWithImplicitConversionOperatorWith1ReturnAttribute
    {
        public class Class
        {
            [return: Attribute1]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
