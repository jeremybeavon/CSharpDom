namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Properties
{
    public static class StaticClassWithNestedSealedClassWithProtectedProperty
    {
        public sealed class Class
        {
            protected string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
