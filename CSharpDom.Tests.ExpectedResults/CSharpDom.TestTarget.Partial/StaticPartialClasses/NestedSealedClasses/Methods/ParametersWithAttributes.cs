namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Methods
{
    public static partial class StaticPartialClassWithNestedSealedClassWithMethodWithParametersWithAttributes
    {
        public sealed class Class
        {
            public void Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
