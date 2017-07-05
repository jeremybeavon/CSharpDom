namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Properties
{
    public class ClassWithNestedAbstractPartialClassWithNewProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
