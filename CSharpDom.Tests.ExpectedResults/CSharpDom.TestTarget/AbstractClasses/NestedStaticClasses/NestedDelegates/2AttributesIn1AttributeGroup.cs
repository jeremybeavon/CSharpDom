namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedStaticClassWithNestedDelegateWith2AttributesIn1AttributeGroup
    {
        public static class Class
        {
            [Attribute1, Attribute2]
            public delegate void DelegateWith2AttributesIn1AttributeGroup();
        }
    }
}
