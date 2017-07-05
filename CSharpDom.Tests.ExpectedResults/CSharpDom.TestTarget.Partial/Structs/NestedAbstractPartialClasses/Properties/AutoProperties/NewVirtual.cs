namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Properties.AutoProperties
{
    public struct StructWithNestedAbstractPartialClassWithNewVirtualAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new virtual string Property { get; set; }
        }
    }
}
