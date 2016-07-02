namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Properties
{
    public abstract class AbstractClassWithNestedClassWithInternalProperty
    {
        public class Class
        {
            internal string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
