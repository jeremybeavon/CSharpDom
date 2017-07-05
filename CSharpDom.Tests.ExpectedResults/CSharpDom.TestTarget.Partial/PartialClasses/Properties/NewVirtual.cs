namespace CSharpDom.TestTarget.Partial.PartialClasses.Properties
{
    public partial class PartialClassWithNewVirtualProperty : BaseClassWithProperty
    {
        public new virtual string Property
        {
            get { return default(string); }
            set { }
        }
    }
}
