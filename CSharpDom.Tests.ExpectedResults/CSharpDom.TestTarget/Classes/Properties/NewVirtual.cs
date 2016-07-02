namespace CSharpDom.TestTarget.Classes.Properties
{
    public class ClassWithNewVirtualProperty : BaseClassWithProperty
    {
        public new virtual string Property
        {
            get { return default(string); }
            set { }
        }
    }
}
