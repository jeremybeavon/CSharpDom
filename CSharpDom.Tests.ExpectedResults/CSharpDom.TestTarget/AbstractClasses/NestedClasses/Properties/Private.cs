namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Properties
{
    public abstract class AbstractClassWithNestedClassWithPrivateProperty
    {
        public class Class
        {
            private string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
