namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedDelegateWith1Attribute
    {
        public partial class Class
        {
            [Attribute1]
            public delegate void DelegateWith1Attribute();
        }
    }
}
