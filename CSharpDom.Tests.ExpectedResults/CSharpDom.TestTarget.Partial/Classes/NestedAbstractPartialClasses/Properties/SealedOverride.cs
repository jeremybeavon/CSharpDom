namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Properties
{
    public class ClassWithNestedAbstractPartialClassWithSealedOverrideProperty
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
