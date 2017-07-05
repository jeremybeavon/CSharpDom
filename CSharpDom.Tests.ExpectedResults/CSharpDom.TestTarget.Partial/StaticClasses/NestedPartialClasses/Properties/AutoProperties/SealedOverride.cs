namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Properties.AutoProperties
{
    public static class StaticClassWithNestedPartialClassWithSealedOverrideAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
