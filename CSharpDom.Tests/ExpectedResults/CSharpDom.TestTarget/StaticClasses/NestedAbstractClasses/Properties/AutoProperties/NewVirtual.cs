namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Properties.AutoProperties
{
    public static class StaticClassWithNestedAbstractClassWithNewVirtualAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new virtual string Property { get; set; }
        }
    }
}
