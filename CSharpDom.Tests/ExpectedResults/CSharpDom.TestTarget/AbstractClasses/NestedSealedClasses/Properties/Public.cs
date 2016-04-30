namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Properties
{
    public abstract class AbstractClassWithNestedSealedClassWithPublicProperty
    {
        public sealed class Class
        {
            public string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
