namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedDelegates
{
    public struct StructWithNestedAbstractClassWithNestedDelegateWith1Attribute
    {
        public abstract class Class
        {
            [Attribute1]
            public delegate void DelegateWith1Attribute();
        }
    }
}
