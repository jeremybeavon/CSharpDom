namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Properties.AutoProperties
{
    public partial struct PartialStructWithNestedClassWithOverrideAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public override string Property { get; set; }
        }
    }
}
