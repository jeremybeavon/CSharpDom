namespace CSharpDom.Reflection.Internal
{
    internal sealed class NamespaceContainer
    {
        public NamespaceContainer(string name, TypeContainer typeContainer)
        {
            Namespace = new NamespaceWithReflection(name, typeContainer);
            TypeContainer = typeContainer;
        }

        public NamespaceWithReflection Namespace { get; private set; }

        public TypeContainer TypeContainer { get; private set; }
    }
}
