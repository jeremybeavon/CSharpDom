namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Properties
{
    public static class StaticClassWithNestedPartialClassWithSealedOverrideProperty
    {
        public class Class : BaseClassWithProperty
        {
            public sealed override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
