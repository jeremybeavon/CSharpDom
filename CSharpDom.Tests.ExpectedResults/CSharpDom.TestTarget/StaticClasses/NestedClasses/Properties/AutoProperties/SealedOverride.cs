namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Properties.AutoProperties
{
    public static class StaticClassWithNestedClassWithSealedOverrideAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
