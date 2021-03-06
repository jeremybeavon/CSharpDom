﻿using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AbstractEventWithCodeAnalysis :
        EditableAbstractEvent<
            AttributeGroupWithCodeAnalysis,
            IAbstractTypeWithCodeAnalysis,
            DelegateReferenceWithCodeAnalysis>,
        IHasSyntax<EventFieldDeclarationSyntax>,
        IHasNode<EventFieldDeclarationSyntax>
    {
        private readonly EventWithCodeAnalysis @event;

        public AbstractEventWithCodeAnalysis(
            ClassMemberVisibilityModifier visibility,
            DelegateReferenceWithCodeAnalysis type,
            string name)
            : this()
        {
            var variable = SyntaxFactory.VariableDeclarator(name);
            Syntax = SyntaxFactory.EventFieldDeclaration(
                default(SyntaxList<AttributeListSyntax>),
                default(SyntaxTokenList).WithClassMemberVisibilityModifier(visibility).Add(SyntaxKind.AbstractKeyword),
                SyntaxFactory.VariableDeclaration(type.Syntax, SyntaxFactory.SingletonSeparatedList(variable)));
        }

        internal AbstractEventWithCodeAnalysis()
        {
            @event = new EventWithCodeAnalysis();
        }
        
        public EventWithCodeAnalysis Event
        {
            get { return @event; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return @event.Attributes; }
            set { @event.Attributes = value; }
        }

        public override IAbstractTypeWithCodeAnalysis DeclaringType
        {
            get { return DeclaringTypeFunc?.Invoke() ?? @event.Node.GetParent<IAbstractTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override DelegateReferenceWithCodeAnalysis EventType
        {
            get { return @event.EventType; }
            set { @event.EventType = value; }
        }
        
        public override string Name
        {
            get { return @event.Name; }
            set { @event.Name = value; }
        }

        public override AbstractMemberVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToAbstractMemberVisibilityModifier(); }
            set
            {
                EventFieldDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithAbstractMemberVisibilityModifier(value));
            }
        }

        public EventFieldDeclarationSyntax Syntax
        {
            get { return @event.Syntax; }
            set { @event.Syntax = value; }
        }
        
        INode<EventFieldDeclarationSyntax> IHasNode<EventFieldDeclarationSyntax>.Node
        {
            get { return @event.Node; }
        }

        internal Func<IAbstractTypeWithCodeAnalysis> DeclaringTypeFunc { get; set; }
    }
}
