namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.Properties
{
    public static class StaticClassWithNestedAbstractPartialClassWithSealedOverrideProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public sealed override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
