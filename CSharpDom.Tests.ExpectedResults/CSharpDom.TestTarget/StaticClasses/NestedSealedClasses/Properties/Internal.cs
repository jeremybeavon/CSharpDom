namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Properties
{
    public static class StaticClassWithNestedSealedClassWithInternalProperty
    {
        public sealed class Class
        {
            internal string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
