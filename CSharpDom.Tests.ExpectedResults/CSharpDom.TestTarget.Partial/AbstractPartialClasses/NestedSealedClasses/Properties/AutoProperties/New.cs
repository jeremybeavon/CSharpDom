namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Properties.AutoProperties
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNewAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public new string Property { get; set; }
        }
    }
}
