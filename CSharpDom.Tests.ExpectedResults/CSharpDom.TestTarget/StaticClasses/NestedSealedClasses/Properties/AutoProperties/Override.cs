namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Properties.AutoProperties
{
    public static class StaticClassWithNestedSealedClassWithOverrideAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public override string Property { get; set; }
        }
    }
}
