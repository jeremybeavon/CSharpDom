namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Methods
{
    public abstract class AbstractClassWithNestedPartialClassWithMethodWith1ReturnAttribute
    {
        public partial class Class
        {
            [return: Attribute1]
            public void Method()
            {
            }
        }
    }
}
