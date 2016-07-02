namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Methods
{
    public abstract class AbstractClassWithNestedSealedClassWithMethodWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public void Method()
            {
            }
        }
    }
}
