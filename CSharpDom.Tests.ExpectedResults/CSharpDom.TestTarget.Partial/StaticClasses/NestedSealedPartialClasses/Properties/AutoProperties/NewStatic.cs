namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Properties.AutoProperties
{
    public static class StaticClassWithNestedSealedPartialClassWithNewStaticAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public new static string Property { get; set; }
        }
    }
}
