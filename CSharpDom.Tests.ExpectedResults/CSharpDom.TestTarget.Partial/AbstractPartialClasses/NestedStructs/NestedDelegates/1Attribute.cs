namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.NestedDelegates
{
    public abstract partial class AbstractPartialClassWithNestedStructWithNestedDelegateWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public delegate void DelegateWith1Attribute();
        }
    }
}
