namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Properties
{
    public sealed class SealedClassWithNestedSealedClassWithInternalProperty
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
