namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Properties
{
    public static class StaticClassWithNestedSealedClassWithPrivateProperty
    {
        public sealed class Class
        {
            private string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
