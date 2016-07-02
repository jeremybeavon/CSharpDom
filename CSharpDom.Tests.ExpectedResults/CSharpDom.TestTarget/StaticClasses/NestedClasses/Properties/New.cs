namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Properties
{
    public static class StaticClassWithNestedClassWithNewProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
