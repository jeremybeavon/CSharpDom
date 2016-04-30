namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Properties
{
    public static class StaticClassWithNestedClassWithOverrideProperty
    {
        public class Class : BaseClassWithProperty
        {
            public override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
