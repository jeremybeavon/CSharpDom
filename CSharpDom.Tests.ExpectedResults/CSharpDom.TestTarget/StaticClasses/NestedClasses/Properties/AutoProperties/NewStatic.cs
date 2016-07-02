namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Properties.AutoProperties
{
    public static class StaticClassWithNestedClassWithNewStaticAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new static string Property { get; set; }
        }
    }
}
