namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Methods
{
    public sealed class SealedClassWithNestedPartialClassWithMethodWithParametersWithAttributes
    {
        public partial class Class
        {
            public void Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
