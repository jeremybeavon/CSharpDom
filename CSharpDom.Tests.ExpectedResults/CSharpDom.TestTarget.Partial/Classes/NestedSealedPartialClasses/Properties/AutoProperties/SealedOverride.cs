namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Properties.AutoProperties
{
    public class ClassWithNestedSealedPartialClassWithSealedOverrideAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
