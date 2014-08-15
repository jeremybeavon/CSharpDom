using System;
using System.Collections.ObjectModel;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom
{
    internal abstract class MemberContainer<TDeclaration> : BasicMemberContainer<TDeclaration>, IMemberContainer,
        IHasCompositeType
        where TDeclaration : TypeDeclarationSyntax
    {
        protected MemberContainer(TDeclaration declaration, ITypeContainer container)
            : base(declaration, container)
        {
            Fields = new Collection<FieldNode>();
            Constructors = new Collection<ConstructorNode>();
            EventProperties = new Collection<EventPropertyNode>();
            OperatorOverloads = new Collection<OperatorOverloadNode>();
            ConversionOperators = new Collection<ConversionOperatorNode>();
            Classes = new Collection<ClassNode>();
            Delegates = new Collection<DelegateNode>();
            Enums = new Collection<EnumNode>();
            Interfaces = new Collection<InterfaceNode>();
            Structs = new Collection<StructNode>();
        }

        public Collection<FieldNode> Fields { get; private set; }

        public Collection<ConstructorNode> Constructors { get; private set; }

        public Collection<EventPropertyNode> EventProperties { get; private set; }

        public Collection<OperatorOverloadNode> OperatorOverloads { get; private set; }

        public Collection<ConversionOperatorNode> ConversionOperators { get; private set; }

        public Collection<ClassNode> Classes { get; private set; }

        public Collection<DelegateNode> Delegates { get; private set; }

        public Collection<EnumNode> Enums { get; private set; }

        public Collection<InterfaceNode> Interfaces { get; private set; }

        public Collection<StructNode> Structs { get; private set; }

        public abstract ICompositeType CompositeType { get; }

        public sealed override IBasicCompositeType BasicCompositeType
        {
            get { return CompositeType; }
        }

        public override void Accept(NodeVisitor visitor)
        {
            base.Accept(visitor);
            VisitCollection(Fields, visitor.VisitField);
            VisitCollection(Constructors, visitor.VisitConstructor);
            VisitCollection(EventProperties, visitor.VisitEventProperty);
            VisitCollection(OperatorOverloads, visitor.VisitOperatorOverload);
            VisitCollection(ConversionOperators, visitor.VisitConversionOperator);
            VisitCollection(Classes, visitor.VisitNestedClass);
            VisitCollection(Delegates, visitor.VisitNestedDelegate);
            VisitCollection(Enums, visitor.VisitNestedEnum);
            VisitCollection(Interfaces, visitor.VisitNestedInterface);
            VisitCollection(Structs, visitor.VisitNestedStruct);
        }
    }
}
