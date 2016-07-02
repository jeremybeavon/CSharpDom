namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Properties
{
    public static class StaticClassWithNestedAbstractClassWithNewVirtualProperty
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
