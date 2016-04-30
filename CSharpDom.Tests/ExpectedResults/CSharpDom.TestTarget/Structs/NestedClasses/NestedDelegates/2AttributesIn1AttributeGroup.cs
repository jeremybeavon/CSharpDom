namespace CSharpDom.TestTarget.Structs.NestedClasses.NestedDelegates
{
    public struct StructWithNestedClassWithNestedDelegateWith2AttributesIn1AttributeGroup
    {
        public class Class
        {
            [Attribute1, Attribute2]
            public delegate void DelegateWith2AttributesIn1AttributeGroup();
        }
    }
}
