namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.Properties
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithSealedOverrideProperty
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
