namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Properties
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithPrivateProperty
    {
        public abstract partial class Class
        {
            private string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
