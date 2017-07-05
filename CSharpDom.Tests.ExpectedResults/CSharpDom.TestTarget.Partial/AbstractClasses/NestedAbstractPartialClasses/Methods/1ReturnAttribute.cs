namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Methods
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithMethodWith1ReturnAttribute
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
