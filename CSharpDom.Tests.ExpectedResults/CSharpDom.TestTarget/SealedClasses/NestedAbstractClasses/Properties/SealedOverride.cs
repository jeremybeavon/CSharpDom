namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Properties
{
    public sealed class SealedClassWithNestedAbstractClassWithSealedOverrideProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public sealed override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
