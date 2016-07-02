namespace CSharpDom.TestTarget.Structs.NestedClasses.Properties.AutoProperties
{
    public struct StructWithNestedClassWithNewAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new string Property { get; set; }
        }
    }
}
