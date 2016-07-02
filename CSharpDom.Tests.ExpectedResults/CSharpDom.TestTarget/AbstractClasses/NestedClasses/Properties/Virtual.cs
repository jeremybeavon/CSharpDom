namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Properties
{
    public abstract class AbstractClassWithNestedClassWithVirtualProperty
    {
        public class Class
        {
            public virtual string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
