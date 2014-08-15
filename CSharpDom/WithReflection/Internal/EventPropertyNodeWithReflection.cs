using System.Reflection;
using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithReflection.Internal
{
    internal class EventPropertyNodeWithReflection : EventPropertyNodeWithSymbols, IEventPropertyWithReflection
    {
        private const BindingFlags Flags = ReflectionMemberHelper.Flags;
        private EventInfo eventInfo;

        public EventPropertyNodeWithReflection(
            EventDeclarationSyntax declaration,
            IMemberContainer container,
            SemanticModel semanticModel)
            : base(declaration, container, semanticModel)
        {
        }

        public EventInfo EventInfo
        {
            get { return eventInfo ?? (eventInfo = ((IHasType)DeclaringType).Type.GetEvent(Symbol.Name, Flags)); }
        }

        public IEventPropertyWithSymbols Symbols
        {
            get { return this; }
        }

        ITypeWithReflection IHasDeclaringType<ITypeWithReflection>.DeclaringType
        {
            get { return (ITypeWithReflection)DeclaringType; }
        }

        public void Accept(IReflectionVisitor visitor)
        {
            Accept(new ReflectionNodeVisitor(visitor));
        }
    }
}
