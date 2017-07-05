namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Properties
{
    public static class StaticClassWithNestedPartialClassWithNewProperty
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
