namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.Properties.AutoProperties
{
    public static class StaticClassWithNestedAbstractPartialClassWithSealedOverrideAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
