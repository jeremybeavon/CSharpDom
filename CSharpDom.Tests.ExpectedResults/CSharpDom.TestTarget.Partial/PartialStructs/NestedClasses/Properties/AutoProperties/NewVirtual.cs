namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Properties.AutoProperties
{
    public partial struct PartialStructWithWithNestedClassWithNewVirtualAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new virtual string Property { get; set; }
        }
    }
}
