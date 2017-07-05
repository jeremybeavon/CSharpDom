namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.Properties
{
    public static class StaticClassWithNestedAbstractPartialClassWithNewProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
