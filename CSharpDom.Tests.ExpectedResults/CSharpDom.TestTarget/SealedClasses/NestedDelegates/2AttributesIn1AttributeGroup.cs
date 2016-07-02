namespace CSharpDom.TestTarget.SealedClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedDelegateWith2AttributesIn1AttributeGroup
    {
        [Attribute1, Attribute2]
        public delegate void DelegateWith2AttributesIn1AttributeGroup();
    }
}
