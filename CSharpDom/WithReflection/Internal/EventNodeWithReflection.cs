using System;
using System.Reflection;
using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithReflection.Internal
{
    internal class EventNodeWithReflection : EventNodeWithSymbols, IEventWithReflection
    {
        private const BindingFlags Flags = ReflectionMemberHelper.Flags;
        private EventInfo eventInfo;

        public EventNodeWithReflection(
            EventFieldDeclarationSyntax declaration,
            IBasicMemberContainer container,
            SemanticModel semanticModel)
            : base(declaration, container, semanticModel)
        {
        }

        public EventInfo EventInfo
        {
            get { return eventInfo ?? (eventInfo = ((IHasType)DeclaringType).Type.GetEvent(Symbol.Name, Flags)); }
        }

        public IEventWithSymbols Symbols
        {
            get { return this; }
        }

        IBasicTypeWithReflection IHasDeclaringType<IBasicTypeWithReflection>.DeclaringType
        {
            get { return (IBasicTypeWithReflection)DeclaringType; }
        }

        public void Accept(IReflectionVisitor visitor)
        {
            Accept(new ReflectionNodeVisitor(visitor));
        }
    }
}
