namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Methods
{
    public sealed class SealedClassWithNestedAbstractClassWithMethodWith1ReturnAttribute
    {
        public abstract class Class
        {
            [return: Attribute1]
            public void Method()
            {
            }
        }
    }
}
