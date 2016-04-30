namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Properties.AutoProperties
{
    public static class StaticClassWithNestedAbstractClassWithNewStaticAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new static string Property { get; set; }
        }
    }
}
