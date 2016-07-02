namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Properties
{
    public abstract class AbstractClassWithNestedSealedClassWithPrivateProperty
    {
        public sealed class Class
        {
            private string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
