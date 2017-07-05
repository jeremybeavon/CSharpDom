namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Properties
{
    public abstract partial class AbstractPartialClassWithNewVirtualProperty : BaseClassWithProperty
    {
        public new virtual string Property
        {
            get { return default(string); }
            set { }
        }
    }
}
