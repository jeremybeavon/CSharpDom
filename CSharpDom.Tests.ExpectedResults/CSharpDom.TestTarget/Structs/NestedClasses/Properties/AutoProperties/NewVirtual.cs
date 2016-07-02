namespace CSharpDom.TestTarget.Structs.NestedClasses.Properties.AutoProperties
{
    public struct StructWithNestedClassWithNewVirtualAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new virtual string Property { get; set; }
        }
    }
}
