namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNestedDelegateWith1Attribute
    {
        public sealed partial class Class
        {
            [Attribute1]
            public delegate void DelegateWith1Attribute();
        }
    }
}
