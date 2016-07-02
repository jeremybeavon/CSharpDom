namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Properties
{
    public static class StaticClassWithNestedSealedClassWithOverrideProperty
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
