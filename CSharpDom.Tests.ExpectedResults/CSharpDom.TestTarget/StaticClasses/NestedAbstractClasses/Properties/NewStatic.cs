namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Properties
{
    public static class StaticClassWithNestedAbstractClassWithNewStaticProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new static string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
