namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Properties
{
    public sealed class SealedClassWithNestedClassWithInternalProperty
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
