namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Properties.AutoProperties
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNewAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public new string Property { get; set; }
        }
    }
}
