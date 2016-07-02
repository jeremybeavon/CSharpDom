namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Properties
{
    public abstract class AbstractClassWithNestedAbstractClassWithNewStaticProperty
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
