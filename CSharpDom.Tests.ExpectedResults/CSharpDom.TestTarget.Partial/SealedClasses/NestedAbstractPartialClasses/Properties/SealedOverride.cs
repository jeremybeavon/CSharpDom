namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Properties
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithSealedOverrideProperty
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
