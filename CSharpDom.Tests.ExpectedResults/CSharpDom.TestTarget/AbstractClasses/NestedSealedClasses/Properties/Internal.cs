namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Properties
{
    public abstract class AbstractClassWithNestedSealedClassWithInternalProperty
    {
        public sealed class Class
        {
            internal string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
