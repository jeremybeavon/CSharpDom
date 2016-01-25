namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class EmptyStructPropertyAccessors
    {
        public EmptyStructPropertyAccessors()
        {
        }

        public EmptyStructPropertyAccessors(
            StructPropertyAccessorVisibilityModifier getAccessorVisibility,
            StructPropertyAccessorVisibilityModifier setAccessorVisibility)
        {
            getAccessorVisibility = GetAccessorVisibility;
            SetAccessorVisibility = setAccessorVisibility;
        }

        public StructPropertyAccessorVisibilityModifier GetAccessorVisibility { get; set; }

        public StructPropertyAccessorVisibilityModifier SetAccessorVisibility { get; set; }
    }
}
