namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Properties
{
    public abstract partial class AbstractPartialClassWithNewProperty : BaseClassWithProperty
    {
        public new string Property
        {
            get { return default(string); }
            set { }
        }
    }
}
