namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Properties
{
    public abstract partial class AbstractPartialClassWithSealedOverrideProperty : BaseClassWithProperty
    {
        public sealed override string Property
        {
            get { return default(string); }
            set { }
        }
    }
}
