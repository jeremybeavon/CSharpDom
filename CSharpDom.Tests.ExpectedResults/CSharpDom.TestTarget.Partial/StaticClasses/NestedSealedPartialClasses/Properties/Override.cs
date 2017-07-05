namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Properties
{
    public static class StaticClassWithNestedSealedPartialClassWithOverrideProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
