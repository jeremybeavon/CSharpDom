namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Properties
{
    public sealed class SealedClassWithNestedSealedClassWithNewProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public new string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
