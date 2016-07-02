namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedDelegates
{
    public struct StructWithNestedAbstractClassWithNestedDelegateWith2AttributesIn1AttributeGroup
    {
        public abstract class Class
        {
            [Attribute1, Attribute2]
            public delegate void DelegateWith2AttributesIn1AttributeGroup();
        }
    }
}
