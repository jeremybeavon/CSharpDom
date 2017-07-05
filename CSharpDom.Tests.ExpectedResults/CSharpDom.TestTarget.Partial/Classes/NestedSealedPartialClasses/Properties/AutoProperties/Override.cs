namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Properties.AutoProperties
{
    public class ClassWithNestedSealedPartialClassWithOverrideAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public override string Property { get; set; }
        }
    }
}
