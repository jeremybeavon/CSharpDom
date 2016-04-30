namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Properties
{
    public abstract class AbstractClassWithNestedAbstractClassWithNewProperty
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
