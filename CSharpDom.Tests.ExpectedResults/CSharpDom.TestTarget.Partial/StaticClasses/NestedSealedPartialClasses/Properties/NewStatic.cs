namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Properties
{
    public static class StaticClassWithNestedSealedPartialClassWithNewStaticProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public new static string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
