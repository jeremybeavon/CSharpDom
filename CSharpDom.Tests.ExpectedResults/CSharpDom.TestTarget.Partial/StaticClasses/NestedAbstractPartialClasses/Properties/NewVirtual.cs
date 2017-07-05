namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.Properties
{
    public static class StaticClassWithNestedAbstractPartialClassWithNewVirtualProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new virtual string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
