namespace CSharpDom.TestTarget.Partial.PartialClasses.Properties
{
    public partial class PartialClassWithSealedOverrideProperty : BaseClassWithProperty
    {
        public sealed override string Property
        {
            get { return default(string); }
            set { }
        }
    }
}
