namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Properties
{
    public class ClassWithNestedAbstractClassWithNewProperty
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
