namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Properties.AutoProperties
{
    public struct StructWithNestedAbstractClassWithNewVirtualAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new virtual string Property { get; set; }
        }
    }
}
