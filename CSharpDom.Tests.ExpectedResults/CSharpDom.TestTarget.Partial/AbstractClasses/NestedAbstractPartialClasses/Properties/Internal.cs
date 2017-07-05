namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Properties
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithInternalProperty
    {
        public abstract partial class Class
        {
            internal string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
