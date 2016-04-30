namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedDelegates
{
    public static class StaticClassWithNestedStaticClassWithNestedDelegateWith2AttributesIn1AttributeGroup
    {
        public static class Class
        {
            [Attribute1, Attribute2]
            public delegate void DelegateWith2AttributesIn1AttributeGroup();
        }
    }
}
