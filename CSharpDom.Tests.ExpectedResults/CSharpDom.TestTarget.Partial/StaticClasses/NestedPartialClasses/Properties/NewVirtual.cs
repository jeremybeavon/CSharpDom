namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Properties
{
    public static class StaticClassWithNestedPartialClassWithNewVirtualProperty
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
