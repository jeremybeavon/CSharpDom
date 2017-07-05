namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.NestedDelegates
{
    public abstract class AbstractClassWithNestedStructWithNestedDelegateWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public delegate void DelegateWith1Attribute();
        }
    }
}
