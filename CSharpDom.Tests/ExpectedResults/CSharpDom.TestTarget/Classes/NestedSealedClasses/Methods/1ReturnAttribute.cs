namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Methods
{
    public class ClassWithNestedSealedClassWithMethodWith1ReturnAttribute
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
