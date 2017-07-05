namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Properties
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithOverrideProperty
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
