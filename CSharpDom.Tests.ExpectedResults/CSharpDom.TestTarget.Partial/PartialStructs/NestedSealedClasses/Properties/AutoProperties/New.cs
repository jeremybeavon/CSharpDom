namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Properties.AutoProperties
{
    public partial struct PartialStructWithNestedSealedClassWithNewAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public new string Property { get; set; }
        }
    }
}
