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
    public sealed class ClassEventPropertyWithCodeAnalysis :
        EditableClassEventProperty<
            AttributeGroupWithCodeAnalysis,
            IClassTypeWithCodeAnalysis,
            DelegateReferenceWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>,
        IHasSyntax<EventDeclarationSyntax>,
        IHasNode<EventDeclarationSyntax>
    {
        private readonly EventPropertyWithCodeAnalysis @event;

        public ClassEventPropertyWithCodeAnalysis(
            ClassMemberVisibilityModifier visibility,
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
                default(SyntaxTokenList).WithClassMemberVisibilityModifier(visibility),
                type.Syntax,
                null,
                SyntaxFactory.Identifier(name),
                SyntaxFactory.AccessorList(SyntaxFactory.List(accessors)));
        }

        internal ClassEventPropertyWithCodeAnalysis()
        {
            @event = new EventPropertyWithCodeAnalysis();
        }
        
        public EventPropertyWithCodeAnalysis EventProperty
        {
            get { return @event; }
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

        public override IClassTypeWithCodeAnalysis DeclaringType
        {
            get { return DeclaringTypeFunc?.Invoke() ?? @event.Node.GetParentNode<IClassTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override DelegateReferenceWithCodeAnalysis EventType
        {
            get { return @event.EventType; }
            set { @event.EventType = value; }
        }

        public override ClassMemberInheritanceModifier InheritanceModifier
        {
            get { return Syntax.Modifiers.ToClassMemberInheritanceModifier(); }
            set
            {
                EventDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithClassMemberInheritanceModifier(value));
            }
        }

        public override string Name
        {
            get { return @event.Name; }
            set { @event.Name = value; }
        }

        public override MethodBodyWithCodeAnalysis RemoveBody
        {
            get { return @event.RemoveBody; }
            set { @event.RemoveBody = value; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToClassMemberVisibilityModifier(); }
            set
            {
                EventDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithClassMemberVisibilityModifier(value));
            }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> AddAttributes
        {
            get { return @event.AddAttributes; }
            set { @event.AddAttributes = value; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> RemoveAttributes
        {
            get { return @event.RemoveAttributes; }
            set { @event.RemoveAttributes = value; }
        }

        public EventDeclarationSyntax Syntax
        {
            get { return @event.Syntax; }
            set { @event.Syntax = value; }
        }
        
        INode<EventDeclarationSyntax> IHasNode<EventDeclarationSyntax>.Node
        {
            get { return @event.Node; }
        }

        internal Func<IClassTypeWithCodeAnalysis> DeclaringTypeFunc { get; set; }
    }
}
