namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Methods
{
    public abstract class AbstractClassWithNestedSealedClassWithMethodWith1ReturnAttribute
    {
        public sealed class Class
        {
            [return: Attribute1]
            public void Method()
            {
            }
        }
    }
}
