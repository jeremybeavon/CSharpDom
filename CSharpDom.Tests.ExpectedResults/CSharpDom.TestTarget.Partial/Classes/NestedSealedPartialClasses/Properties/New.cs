namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Properties
{
    public class ClassWithNestedSealedPartialClassWithNewProperty
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
