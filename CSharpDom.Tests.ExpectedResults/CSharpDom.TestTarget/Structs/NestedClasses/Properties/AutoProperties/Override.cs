namespace CSharpDom.TestTarget.Structs.NestedClasses.Properties.AutoProperties
{
    public struct StructWithNestedClassWithOverrideAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public override string Property { get; set; }
        }
    }
}
