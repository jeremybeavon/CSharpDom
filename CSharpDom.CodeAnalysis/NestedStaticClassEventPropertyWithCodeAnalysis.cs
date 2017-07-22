using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis
{
    public sealed class NestedStaticClassEventPropertyWithCodeAnalysis :
        EditableStaticClassEventProperty<
            AttributeGroupWithCodeAnalysis,
            INestedStaticTypeWithCodeAnalysis,
            DelegateReferenceWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>,
        IHasSyntax<EventDeclarationSyntax>,
        IHasNode<EventDeclarationSyntax>
    {
        private readonly EventPropertyWithCodeAnalysis @event;

        public NestedStaticClassEventPropertyWithCodeAnalysis(
            StaticClassMemberVisibilityModifier visibility,
            DelegateReferenceWithCodeAnalysis type,
            string name,
            MethodBodyWithCodeAnalysis addAccessor,
            MethodBodyWithCodeAnalysis removeAccessor)
            : this()
        {
            IEnumerable<AccessorDeclarationSyntax> accessors = new AccessorDeclarationSyntax[]
            {
                SyntaxFactory.AccessorDeclaration(SyntaxKind.AddKeyword, addAccessor.Syntax),
                SyntaxFactory.AccessorDeclaration(SyntaxKind.RemoveKeyword, removeAccessor.Syntax)
            };
            Syntax = SyntaxFactory.EventDeclaration(
                default(SyntaxList<AttributeListSyntax>),
                default(SyntaxTokenList).WithStaticClassMemberVisibilityModifier(visibility),
                type.Syntax,
                null,
                SyntaxFactory.Identifier(name),
                SyntaxFactory.AccessorList(SyntaxFactory.List(accessors)));
        }

        internal NestedStaticClassEventPropertyWithCodeAnalysis()
        {
            @event = new EventPropertyWithCodeAnalysis();
        }
        
        public EventPropertyWithCodeAnalysis EventProperty
        {
            get { return @event; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> AddAttributes
        {
            get { return @event.AddAttributes; }
            set { @event.AddAttributes = value; }
        }

        public override MethodBodyWithCodeAnalysis AddBody
        {
            get { return @event.AddBody; }
            set { @event.AddBody = value; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return @event.Attributes; }
            set { @event.Attributes = value; }
        }

        public override INestedStaticTypeWithCodeAnalysis DeclaringType
        {
            get { return @event.Node.GetParentNode<INestedStaticTypeWithCodeAnalysis>(); }
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

        public override ICollection<AttributeGroupWithCodeAnalysis> RemoveAttributes
        {
            get { return @event.RemoveAttributes; }
            set { @event.RemoveAttributes = value; }
        }

        public override MethodBodyWithCodeAnalysis RemoveBody
        {
            get { return @event.RemoveBody; }
            set { @event.RemoveBody = value; }
        }

        public EventDeclarationSyntax Syntax
        {
            get { return @event.Syntax; }
            set { @event.Syntax = value; }
        }

        public override StaticClassMemberVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToStaticClassMemberVisibilityModifier(); }
            set
            {
                EventDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithStaticClassMemberVisibilityModifier(value));
            }
        }
        
        INode<EventDeclarationSyntax> IHasNode<EventDeclarationSyntax>.Node
        {
            get { return @event.Node; }
        }
    }
}
