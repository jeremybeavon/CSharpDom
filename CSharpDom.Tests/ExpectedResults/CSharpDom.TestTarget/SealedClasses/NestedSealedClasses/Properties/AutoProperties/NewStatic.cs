namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Properties.AutoProperties
{
    public sealed class SealedClassWithNestedSealedClassWithNewStaticAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public new static string Property { get; set; }
        }
    }
}
