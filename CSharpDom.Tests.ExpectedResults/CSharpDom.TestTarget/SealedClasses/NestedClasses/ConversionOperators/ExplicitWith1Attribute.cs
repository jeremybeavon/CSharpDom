namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.ConversionOperators
{
    public sealed class SealedClassWithNestedClassWithExplicitConversionOperatorWith1Attribute
    {
        public class Class
        {
            [Attribute1]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
