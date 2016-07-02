namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Properties
{
    public static class StaticClassWithNestedAbstractClassWithNewProperty
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
