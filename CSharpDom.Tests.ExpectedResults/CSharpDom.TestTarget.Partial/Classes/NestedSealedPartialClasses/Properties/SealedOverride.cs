namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Properties
{
    public class ClassWithNestedSealedPartialClassWithSealedOverrideProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public sealed override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
