namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.NestedDelegates
{
    public partial class PartialClassWithNestedStructWithNestedDelegateWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public delegate void DelegateWith1Attribute();
        }
    }
}
