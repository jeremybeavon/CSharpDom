namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Properties.AutoProperties
{
    public static class StaticClassWithNestedAbstractClassWithNewAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new string Property { get; set; }
        }
    }
}
