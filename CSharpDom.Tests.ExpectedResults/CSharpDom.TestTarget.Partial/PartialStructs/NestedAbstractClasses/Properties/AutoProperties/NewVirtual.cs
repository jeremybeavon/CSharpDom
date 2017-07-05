namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Properties.AutoProperties
{
    public partial struct PartialStructWithWithNestedAbstractClassWithNewVirtualAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new virtual string Property { get; set; }
        }
    }
}
