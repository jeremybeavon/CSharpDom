namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Properties
{
    public class ClassWithNestedSealedPartialClassWithPrivateProperty
    {
        public sealed partial class Class
        {
            private string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
