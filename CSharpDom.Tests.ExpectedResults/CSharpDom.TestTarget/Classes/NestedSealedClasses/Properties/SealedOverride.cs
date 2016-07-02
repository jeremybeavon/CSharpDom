namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Properties
{
    public class ClassWithNestedSealedClassWithSealedOverrideProperty
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
