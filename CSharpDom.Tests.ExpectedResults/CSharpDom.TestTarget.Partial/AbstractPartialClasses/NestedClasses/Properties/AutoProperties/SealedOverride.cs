namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Properties.AutoProperties
{
    public abstract partial class AbstractPartialClassWithNestedClassWithSealedOverrideAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
