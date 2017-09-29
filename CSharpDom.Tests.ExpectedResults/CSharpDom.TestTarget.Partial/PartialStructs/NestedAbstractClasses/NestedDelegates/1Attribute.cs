namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.NestedDelegates
{
    public partial struct PartialStructWithNestedAbstractClassWithNestedDelegateWith1Attribute
    {
        public abstract class Class
        {
            [Attribute1]
            public delegate void DelegateWith1Attribute();
        }
    }
}
