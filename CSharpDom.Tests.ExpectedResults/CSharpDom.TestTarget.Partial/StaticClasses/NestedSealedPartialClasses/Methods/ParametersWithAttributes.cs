namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Methods
{
    public static class StaticClassWithNestedSealedPartialClassWithMethodWithParametersWithAttributes
    {
        public sealed partial class Class
        {
            public void Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
