namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Properties
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithVirtualProperty
    {
        public abstract partial class Class
        {
            public virtual string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
