namespace CSharpDom.TestTarget.AbstractClasses.Properties
{
    public abstract class AbstractClassWithNewProperty : BaseClassWithProperty
    {
        public new string Property
        {
            get { return default(string); }
            set { }
        }
    }
}
