namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Properties
{
    public abstract class AbstractClassWithNestedSealedClassWithProtectedProperty
    {
        public sealed class Class
        {
            protected string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
