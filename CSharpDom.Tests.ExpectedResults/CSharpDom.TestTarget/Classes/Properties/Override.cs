namespace CSharpDom.TestTarget.Classes.Properties
{
    public class ClassWithOverrideProperty : BaseClassWithProperty
    {
        public override string Property
        {
            get { return default(string); }
            set { }
        }
    }
}
