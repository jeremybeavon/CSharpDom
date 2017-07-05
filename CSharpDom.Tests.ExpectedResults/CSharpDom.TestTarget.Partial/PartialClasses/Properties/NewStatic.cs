namespace CSharpDom.TestTarget.Partial.PartialClasses.Properties
{
    public partial class PartialClassWithNewStaticProperty : BaseClassWithProperty
    {
        public new static string Property
        {
            get { return default(string); }
            set { }
        }
    }
}
