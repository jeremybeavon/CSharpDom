namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Properties.AutoProperties
{
    public static class StaticClassWithNestedSealedClassWithNewStaticAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public new static string Property { get; set; }
        }
    }
}
