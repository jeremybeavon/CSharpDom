namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Methods
{
    public sealed partial class SealedPartialClassWithNestedClassWithMethodWithParametersWithAttributes
    {
        public class Class
        {
            public void Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
