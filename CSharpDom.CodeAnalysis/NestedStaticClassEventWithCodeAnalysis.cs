﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis
{
    public sealed class NestedStaticClassEventWithCodeAnalysis :
        EditableStaticClassEvent<
            AttributeGroupWithCodeAnalysis,
            INestedStaticTypeWithCodeAnalysis,
            DelegateReferenceWithCodeAnalysis>,
        IHasSyntax<EventFieldDeclarationSyntax>,
        IHasNode<EventFieldDeclarationSyntax>
    {
        private readonly EventWithCodeAnalysis @event;

        public NestedStaticClassEventWithCodeAnalysis(
            StaticClassMemberVisibilityModifier visibility,
            DelegateReferenceWithCodeAnalysis type,
            string name)
            : this()
        {
            VariableDeclaratorSyntax syntax = SyntaxFactory.VariableDeclarator(name);
            Syntax = SyntaxFactory.EventFieldDeclaration(
                default(SyntaxList<AttributeListSyntax>),
                default(SyntaxTokenList).WithStaticClassMemberVisibilityModifier(visibility),
                SyntaxFactory.VariableDeclaration(type.Syntax, SyntaxFactory.SingletonSeparatedList(syntax)));
        }

        internal NestedStaticClassEventWithCodeAnalysis()
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

        public override INestedStaticTypeWithCodeAnalysis DeclaringType
        {
            get { return DeclaringTypeFunc?.Invoke() ?? @event.Node.GetParent<INestedStaticTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override DelegateReferenceWithCodeAnalysis EventType
        {
            get { return @event.EventType; }
            set { @event.EventType = value; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> FieldAttributes
        {
            get { return @event.AttributeList.TargetedAttributes; }
            set { @event.AttributeList.TargetedAttributes = value; }
        }
        
        public override string Name
        {
            get { return @event.Name; }
            set { @event.Name = value; }
        }

        public EventFieldDeclarationSyntax Syntax
        {
            get { return @event.Syntax; }
            set { @event.Syntax = value; }
        }

        public override StaticClassMemberVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToStaticClassMemberVisibilityModifier(); }
            set
            {
                EventFieldDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithStaticClassMemberVisibilityModifier(value));
            }
        }
        
        INode<EventFieldDeclarationSyntax> IHasNode<EventFieldDeclarationSyntax>.Node
        {
            get { return @event.Node; }
        }

        internal Func<INestedStaticTypeWithCodeAnalysis> DeclaringTypeFunc { get; set; }
    }
}
