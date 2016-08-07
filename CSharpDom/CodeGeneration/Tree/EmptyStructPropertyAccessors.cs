namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class EmptyStructPropertyAccessors
    {
        public EmptyStructPropertyAccessors()
        {
        }

        public EmptyStructPropertyAccessors(
            StructAccessorVisibilityModifier getAccessorVisibility,
            StructAccessorVisibilityModifier setAccessorVisibility)
        {
            getAccessorVisibility = GetAccessorVisibility;
            SetAccessorVisibility = setAccessorVisibility;
        }

        public StructAccessorVisibilityModifier GetAccessorVisibility { get; set; }

        public StructAccessorVisibilityModifier SetAccessorVisibility { get; set; }
    }
}
