namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class EmptyClassPropertyAccessors
    {
        public EmptyClassPropertyAccessors()
        {
        }

        public EmptyClassPropertyAccessors(
            ClassAccessorVisibilityModifier getAccessorVisibility,
            ClassAccessorVisibilityModifier setAccessorVisibility)
        {
            getAccessorVisibility = GetAccessorVisibility;
            SetAccessorVisibility = setAccessorVisibility;
        }

        public ClassAccessorVisibilityModifier GetAccessorVisibility { get; set; }

        public ClassAccessorVisibilityModifier SetAccessorVisibility { get; set; }
    }
}
