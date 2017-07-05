namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Properties.AutoProperties
{
    public partial struct PartialStructWithWithNestedSealedClassWithOverrideAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public override string Property { get; set; }
        }
    }
}
