namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Properties
{
    public class ClassWithNestedAbstractClassWithNewStaticProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new static string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
