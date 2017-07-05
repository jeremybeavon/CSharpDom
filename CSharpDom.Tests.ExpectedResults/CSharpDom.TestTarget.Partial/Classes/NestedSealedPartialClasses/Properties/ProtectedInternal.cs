namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Properties
{
    public class ClassWithNestedSealedPartialClassWithProtectedInternalProperty
    {
        public sealed partial class Class
        {
            protected internal string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
