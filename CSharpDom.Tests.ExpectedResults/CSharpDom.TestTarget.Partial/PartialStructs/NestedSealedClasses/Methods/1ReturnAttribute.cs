namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Methods
{
    public partial struct PartialStructWithNestedSealedClassWithMethodWith1ReturnAttribute
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
