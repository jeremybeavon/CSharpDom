namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Properties.AutoProperties
{
    public partial class PartialClassWithNestedClassWithSealedOverrideAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
