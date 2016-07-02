namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Properties.AutoProperties
{
    public sealed class SealedClassWithNestedSealedClassWithOverrideAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public override string Property { get; set; }
        }
    }
}
