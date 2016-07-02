namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Properties
{
    public static class StaticClassWithNestedClassWithNewVirtualProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new virtual string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
