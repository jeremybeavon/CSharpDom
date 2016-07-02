namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Properties
{
    public static class StaticClassWithNestedSealedClassWithNewProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public new string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
