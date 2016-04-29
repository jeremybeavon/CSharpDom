namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Properties
{
    public class ClassWithNestedAbstractClassWithNewVirtualProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new virtual string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
