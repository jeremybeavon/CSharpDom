namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Properties
{
    public static class StaticClassWithNestedPartialClassWithOverrideProperty
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
