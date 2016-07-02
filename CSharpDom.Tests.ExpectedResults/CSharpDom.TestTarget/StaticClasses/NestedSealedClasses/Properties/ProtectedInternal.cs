namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Properties
{
    public static class StaticClassWithNestedSealedClassWithProtectedInternalProperty
    {
        public sealed class Class
        {
            protected internal string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
