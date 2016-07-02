namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Properties
{
    public sealed class SealedClassWithNestedClassWithPrivateProperty
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
