namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithNestedClassWithExplicitConversionOperatorWith1Attribute
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
