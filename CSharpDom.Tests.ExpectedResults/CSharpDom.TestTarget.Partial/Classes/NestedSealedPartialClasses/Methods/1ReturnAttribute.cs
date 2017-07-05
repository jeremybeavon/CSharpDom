namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Methods
{
    public class ClassWithNestedSealedPartialClassWithMethodWith1ReturnAttribute
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
