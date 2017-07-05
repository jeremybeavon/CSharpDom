namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Properties
{
    public class ClassWithNestedSealedPartialClassWithInternalProperty
    {
        public sealed partial class Class
        {
            internal string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
