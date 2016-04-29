namespace CSharpDom.TestTarget.Classes.Properties
{
    public class ClassWithNewStaticProperty : BaseClassWithProperty
    {
        public new static string Property
        {
            get { return default(string); }
            set { }
        }
    }
}
