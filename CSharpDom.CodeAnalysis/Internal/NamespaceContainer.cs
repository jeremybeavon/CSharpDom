namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class NamespaceContainer
    {
        public NamespaceContainer(string name)
        {
            TypeContainer = new TypeContainer();
            Namespace = new NamespaceWithCodeAnalysis(name, TypeContainer);
        }

        public NamespaceWithCodeAnalysis Namespace { get; private set; }

        public TypeContainer TypeContainer { get; private set; }
    }
}
