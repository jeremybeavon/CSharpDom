namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Properties.AutoProperties
{
    public static partial class StaticPartialClassWithNestedSealedClassWithSealedOverrideAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
