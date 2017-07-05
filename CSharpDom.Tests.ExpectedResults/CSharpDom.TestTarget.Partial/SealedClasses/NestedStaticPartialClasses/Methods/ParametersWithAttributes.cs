namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.Methods
{
    public sealed class SealedClassWithNestedStaticPartialClassWithMethodWithParametersWithAttributes
    {
        public static partial class Class
        {
            public static void Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
