namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Properties.AutoProperties
{
    public abstract class AbstractClassWithNestedSealedClassWithSealedOverrideAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
