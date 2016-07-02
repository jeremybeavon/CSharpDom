namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Properties.AutoProperties
{
    public sealed class SealedClassWithNestedClassWithSealedOverrideAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
