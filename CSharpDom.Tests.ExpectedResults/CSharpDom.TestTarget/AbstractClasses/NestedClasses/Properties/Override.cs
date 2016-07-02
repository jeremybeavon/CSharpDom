namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Properties
{
    public abstract class AbstractClassWithNestedClassWithOverrideProperty
    {
        public class Class : BaseClassWithProperty
        {
            public override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
