namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Properties
{
    public sealed class SealedClassWithNestedSealedClassWithPrivateProperty
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
