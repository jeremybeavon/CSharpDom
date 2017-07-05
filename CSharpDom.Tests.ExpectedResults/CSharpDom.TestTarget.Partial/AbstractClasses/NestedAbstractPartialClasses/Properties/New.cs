namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Properties
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithNewProperty
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
