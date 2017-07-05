namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Methods
{
    public sealed class SealedClassWithNestedSealedPartialClassWithMethodWith1ReturnAttribute
    {
        public sealed partial class Class
        {
            [return: Attribute1]
            public void Method()
            {
            }
        }
    }
}
