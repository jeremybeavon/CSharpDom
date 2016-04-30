namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Properties.AutoProperties
{
    public static class StaticClassWithNestedSealedClassWithNewAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public new string Property { get; set; }
        }
    }
}
