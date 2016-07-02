namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Properties
{
    public abstract class AbstractClassWithNestedAbstractClassWithOverrideProperty
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
