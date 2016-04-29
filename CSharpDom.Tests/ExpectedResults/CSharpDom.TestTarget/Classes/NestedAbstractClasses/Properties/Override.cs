namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Properties
{
    public class ClassWithNestedAbstractClassWithOverrideProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
