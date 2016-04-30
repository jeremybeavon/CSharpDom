namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Properties
{
    public static class StaticClassWithNestedAbstractClassWithSealedOverrideProperty
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
