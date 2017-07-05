namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Methods
{
    public static class StaticClassWithNestedSealedPartialClassWithMethodWith2ReturnAttributesIn1AttributeGroup
    {
        public sealed partial class Class
        {
            [return: Attribute1, Attribute2]
            public void Method()
            {
            }
        }
    }
}
