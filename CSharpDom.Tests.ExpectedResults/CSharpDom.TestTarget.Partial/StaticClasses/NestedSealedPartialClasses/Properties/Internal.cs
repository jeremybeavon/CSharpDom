namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Properties
{
    public static class StaticClassWithNestedSealedPartialClassWithInternalProperty
    {
        public sealed partial class Class
        {
            internal string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
