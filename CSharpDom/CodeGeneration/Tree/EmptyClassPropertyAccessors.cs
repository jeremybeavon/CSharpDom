namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class EmptyClassPropertyAccessors
    {
        public EmptyClassPropertyAccessors()
        {
        }

        public EmptyClassPropertyAccessors(
            ClassPropertyAccessorVisibilityModifier getAccessorVisibility,
            ClassPropertyAccessorVisibilityModifier setAccessorVisibility)
        {
            getAccessorVisibility = GetAccessorVisibility;
            SetAccessorVisibility = setAccessorVisibility;
        }

        public ClassPropertyAccessorVisibilityModifier GetAccessorVisibility { get; set; }

        public ClassPropertyAccessorVisibilityModifier SetAccessorVisibility { get; set; }
    }
}
