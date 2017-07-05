namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Properties.AutoProperties
{
    public sealed class SealedClassWithNestedSealedPartialClassWithNewStaticAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public new static string Property { get; set; }
        }
    }
}
