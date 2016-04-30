namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Properties.AutoProperties
{
    public abstract class AbstractClassWithNestedSealedClassWithOverrideAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public override string Property { get; set; }
        }
    }
}
