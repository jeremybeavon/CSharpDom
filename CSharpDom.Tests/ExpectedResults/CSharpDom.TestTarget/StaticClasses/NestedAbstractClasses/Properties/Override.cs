namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Properties
{
    public static class StaticClassWithNestedAbstractClassWithOverrideProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
