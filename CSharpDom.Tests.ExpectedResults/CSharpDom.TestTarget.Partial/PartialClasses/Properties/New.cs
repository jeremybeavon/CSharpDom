namespace CSharpDom.TestTarget.Partial.PartialClasses.Properties
{
    public partial class PartialClassWithNewProperty : BaseClassWithProperty
    {
        public new string Property
        {
            get { return default(string); }
            set { }
        }
    }
}
