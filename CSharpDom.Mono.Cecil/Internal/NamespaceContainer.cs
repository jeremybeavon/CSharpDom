namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class NamespaceContainer
    {
        public NamespaceContainer(string name)
        {
            TypeContainer = new TypeContainer();
            Namespace = new NamespaceWithMonoCecil(name, TypeContainer);
        }

        public NamespaceWithMonoCecil Namespace { get; private set; }

        public TypeContainer TypeContainer { get; private set; }
    }
}
