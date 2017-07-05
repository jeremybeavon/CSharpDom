namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Properties.AutoProperties
{
    public partial struct PartialStructWithWithNestedSealedClassWithNewAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public new string Property { get; set; }
        }
    }
}
