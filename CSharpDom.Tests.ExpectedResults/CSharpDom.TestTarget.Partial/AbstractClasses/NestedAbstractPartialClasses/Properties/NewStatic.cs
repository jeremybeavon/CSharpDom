namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Properties
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithNewStaticProperty
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
