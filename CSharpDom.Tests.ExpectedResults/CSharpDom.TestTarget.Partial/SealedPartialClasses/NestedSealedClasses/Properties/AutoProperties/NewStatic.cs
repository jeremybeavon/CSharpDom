namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Properties.AutoProperties
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNewStaticAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public new static string Property { get; set; }
        }
    }
}
