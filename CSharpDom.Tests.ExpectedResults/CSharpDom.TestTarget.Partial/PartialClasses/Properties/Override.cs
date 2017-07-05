namespace CSharpDom.TestTarget.Partial.PartialClasses.Properties
{
    public partial class PartialClassWithOverrideProperty : BaseClassWithProperty
    {
        public override string Property
        {
            get { return default(string); }
            set { }
        }
    }
}
