namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Properties
{
    public abstract class AbstractClassWithNestedSealedClassWithProtectedInternalProperty
    {
        public sealed class Class
        {
            protected internal string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
