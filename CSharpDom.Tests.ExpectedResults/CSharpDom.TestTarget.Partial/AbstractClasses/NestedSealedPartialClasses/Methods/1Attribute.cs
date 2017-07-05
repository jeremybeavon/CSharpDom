namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Methods
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithMethodWith1Attribute
    {
        public sealed partial class Class
        {
            [Attribute1]
            public void Method()
            {
            }
        }
    }
}
