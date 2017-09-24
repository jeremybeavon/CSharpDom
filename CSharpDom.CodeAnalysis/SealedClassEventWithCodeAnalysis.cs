using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class SealedClassEventWithCodeAnalysis :
        EditableSealedClassEvent<
            AttributeGroupWithCodeAnalysis,
            ISealedTypeWithCodeAnalysis,
            DelegateReferenceWithCodeAnalysis>,
        IHasSyntax<EventFieldDeclarationSyntax>,
        IHasNode<EventFieldDeclarationSyntax>
    {
        private readonly ClassEventWithCodeAnalysis @event;

        public SealedClassEventWithCodeAnalysis(
            ClassMemberVisibilityModifier visibility,
            DelegateReferenceWithCodeAnalysis type,
            string name)
            : this(new ClassEventWithCodeAnalysis(visibility, type, name))
        {
        }
        
        internal SealedClassEventWithCodeAnalysis(ClassEventWithCodeAnalysis @event = null)
        {
            this.@event = @event ?? new ClassEventWithCodeAnalysis();
            this.@event.DeclaringTypeFunc = () => DeclaringType.Class;
        }
        
        public ClassEventWithCodeAnalysis Event
        {
            get { return @event; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return @event.Attributes; }
            set { @event.Attributes = value; }
        }

        public override ISealedTypeWithCodeAnalysis DeclaringType
        {
            get { return DeclaringTypeFunc?.Invoke() ?? @event.Event.Node.GetParentNode<ISealedTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override DelegateReferenceWithCodeAnalysis EventType
        {
            get { return @event.EventType; }
            set { @event.EventType = value; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> FieldAttributes
        {
            get { return @event.FieldAttributes; }
            set { @event.FieldAttributes = value; }
        }

        public override SealedClassMemberInheritanceModifier InheritanceModifier
        {
            get { return Syntax.Modifiers.ToSealedClassMemberInheritanceModifier(); }
            set
            {
                EventFieldDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithSealedClassMemberInheritanceModifier(value));
            }
        }

        public override string Name
        {
            get { return @event.Name; }
            set { @event.Name = value; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return @event.Visibility; }
            set { @event.Visibility = value; }
        }

        public EventFieldDeclarationSyntax Syntax
        {
            get { return @event.Syntax; }
            set { @event.Syntax = value; }
        }
        
        INode<EventFieldDeclarationSyntax> IHasNode<EventFieldDeclarationSyntax>.Node
        {
            get { return @event.Event.Node; }
        }

        internal Func<ISealedTypeWithCodeAnalysis> DeclaringTypeFunc { get; set; }
    }
}
