namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Properties
{
    public static class StaticClassWithNestedPartialClassWithNewStaticProperty
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
