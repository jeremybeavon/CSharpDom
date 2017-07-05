namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.Properties
{
    public static class StaticClassWithNestedAbstractPartialClassWithOverrideProperty
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
