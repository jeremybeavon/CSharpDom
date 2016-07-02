namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Properties
{
    public sealed class SealedClassWithNestedClassWithSealedOverrideProperty
    {
        public class Class : BaseClassWithProperty
        {
            public sealed override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
