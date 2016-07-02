namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Methods
{
    public static class StaticClassWithNestedSealedClassWithMethodWith2ReturnAttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            [return: Attribute1, Attribute2]
            public void Method()
            {
            }
        }
    }
}
