namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Methods
{
    public static class StaticClassWithNestedPartialClassWithMethodWithParametersWithAttributes
    {
        public partial class Class
        {
            public void Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
