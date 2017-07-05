namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Properties.AutoProperties
{
    public partial struct PartialStructWithWithNestedSealedClassWithNewStaticAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public new static string Property { get; set; }
        }
    }
}
