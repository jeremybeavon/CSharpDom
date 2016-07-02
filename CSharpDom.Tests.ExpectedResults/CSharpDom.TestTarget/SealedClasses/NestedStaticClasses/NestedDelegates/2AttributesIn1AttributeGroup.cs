namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedStaticClassWithNestedDelegateWith2AttributesIn1AttributeGroup
    {
        public static class Class
        {
            [Attribute1, Attribute2]
            public delegate void DelegateWith2AttributesIn1AttributeGroup();
        }
    }
}
