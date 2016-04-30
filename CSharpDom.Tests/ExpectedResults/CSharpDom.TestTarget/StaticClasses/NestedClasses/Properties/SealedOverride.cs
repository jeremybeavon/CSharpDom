namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Properties
{
    public static class StaticClassWithNestedClassWithSealedOverrideProperty
    {
        public class Class : BaseClassWithProperty
        {
            public sealed override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
