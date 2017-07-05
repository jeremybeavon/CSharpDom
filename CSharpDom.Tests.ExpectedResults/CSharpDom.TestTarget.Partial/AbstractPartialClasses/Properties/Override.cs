namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Properties
{
    public abstract partial class AbstractPartialClassWithOverrideProperty : BaseClassWithProperty
    {
        public override string Property
        {
            get { return default(string); }
            set { }
        }
    }
}
