namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Properties.AutoProperties
{
    public static class StaticClassWithNestedAbstractClassWithSealedOverrideAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
