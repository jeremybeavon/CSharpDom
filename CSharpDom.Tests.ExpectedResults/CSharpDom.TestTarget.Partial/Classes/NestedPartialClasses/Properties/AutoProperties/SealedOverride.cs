namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Properties.AutoProperties
{
    public class ClassWithNestedPartialClassWithSealedOverrideAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
