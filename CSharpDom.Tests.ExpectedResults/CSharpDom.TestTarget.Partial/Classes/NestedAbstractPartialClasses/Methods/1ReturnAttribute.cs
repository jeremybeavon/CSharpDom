namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Methods
{
    public class ClassWithNestedAbstractPartialClassWithMethodWith1ReturnAttribute
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
