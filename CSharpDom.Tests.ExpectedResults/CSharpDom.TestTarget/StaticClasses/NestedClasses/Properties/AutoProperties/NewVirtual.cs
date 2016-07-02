namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Properties.AutoProperties
{
    public static class StaticClassWithNestedClassWithNewVirtualAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new virtual string Property { get; set; }
        }
    }
}
