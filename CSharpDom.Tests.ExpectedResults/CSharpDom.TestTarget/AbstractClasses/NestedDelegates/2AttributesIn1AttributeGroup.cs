namespace CSharpDom.TestTarget.AbstractClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedDelegateWith2AttributesIn1AttributeGroup
    {
        [Attribute1, Attribute2]
        public delegate void DelegateWith2AttributesIn1AttributeGroup();
    }
}
