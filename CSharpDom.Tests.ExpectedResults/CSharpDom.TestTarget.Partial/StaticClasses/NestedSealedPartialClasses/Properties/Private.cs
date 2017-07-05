namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Properties
{
    public static class StaticClassWithNestedSealedPartialClassWithPrivateProperty
    {
        public sealed partial class Class
        {
            private string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
