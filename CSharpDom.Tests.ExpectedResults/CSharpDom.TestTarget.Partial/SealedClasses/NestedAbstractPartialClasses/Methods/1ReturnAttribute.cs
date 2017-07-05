namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Methods
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithMethodWith1ReturnAttribute
    {
        public abstract partial class Class
        {
            [return: Attribute1]
            public void Method()
            {
            }
        }
    }
}
