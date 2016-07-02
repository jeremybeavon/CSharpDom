namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Properties
{
    public static class StaticClassWithNestedClassWithNewStaticProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new static string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
