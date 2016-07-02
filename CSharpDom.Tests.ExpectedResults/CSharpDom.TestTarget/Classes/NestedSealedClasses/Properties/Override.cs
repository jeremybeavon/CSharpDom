namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Properties
{
    public class ClassWithNestedSealedClassWithOverrideProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
