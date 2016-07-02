namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Properties.AutoProperties
{
    public sealed class SealedClassWithNestedSealedClassWithNewAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public new string Property { get; set; }
        }
    }
}
