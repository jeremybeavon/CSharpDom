namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Properties.AutoProperties
{
    public static class StaticClassWithNestedAbstractClassWithOverrideAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public override string Property { get; set; }
        }
    }
}
