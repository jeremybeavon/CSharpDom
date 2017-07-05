namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Properties.AutoProperties
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithOverrideAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public override string Property { get; set; }
        }
    }
}
