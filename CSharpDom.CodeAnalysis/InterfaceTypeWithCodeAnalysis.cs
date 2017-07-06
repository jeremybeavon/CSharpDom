using System;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using CSharpDom.Common;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis
{
    public sealed class InterfaceTypeWithCodeAnalysis :
        EditableInterfaceType<
            AttributeGroupWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            InterfaceEventWithCodeAnalysis,
            InterfacePropertyWithCodeAnalysis,
            InterfaceIndexerWithCodeAnalysis,
            InterfaceMethodWithCodeAnalysis>,
        IHasSyntax<InterfaceDeclarationSyntax>
    {
        private readonly Node<InterfaceTypeWithCodeAnalysis, InterfaceDeclarationSyntax> node;
        private readonly AttributeListWrapper<InterfaceTypeWithCodeAnalysis, InterfaceDeclarationSyntax> attributes;
        private readonly InterfaceMemberListWrapper<InterfaceEventWithCodeAnalysis, EventFieldDeclarationSyntax> events;
        private readonly GenericParameterDeclarationListWrapper<InterfaceTypeWithCodeAnalysis, InterfaceDeclarationSyntax> genericParameters;
        private readonly BaseTypeListWrapper<InterfaceTypeWithCodeAnalysis, InterfaceDeclarationSyntax> interfaces;
        private readonly InterfaceMemberListWrapper<InterfacePropertyWithCodeAnalysis, PropertyDeclarationSyntax> properties;
        private readonly InterfaceMemberListWrapper<InterfaceIndexerWithCodeAnalysis, IndexerDeclarationSyntax> indexers;
        private readonly InterfaceMemberListWrapper<InterfaceMethodWithCodeAnalysis, MethodDeclarationSyntax> methods;
        private readonly MemberList<InterfaceTypeWithCodeAnalysis, InterfaceDeclarationSyntax> members;
        
        internal InterfaceTypeWithCodeAnalysis()
        {
            node = new Node<InterfaceTypeWithCodeAnalysis, InterfaceDeclarationSyntax>(this);
            attributes = new AttributeListWrapper<InterfaceTypeWithCodeAnalysis, InterfaceDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax));
            events = new InterfaceMemberListWrapper<InterfaceEventWithCodeAnalysis, EventFieldDeclarationSyntax>(
                node,
                () => new InterfaceEventWithCodeAnalysis());
            genericParameters = new GenericParameterDeclarationListWrapper<InterfaceTypeWithCodeAnalysis, InterfaceDeclarationSyntax>(
                node,
                syntax => syntax.TypeParameterList,
                (parentSyntax, childSyntax) => parentSyntax.WithTypeParameterList(childSyntax),
                syntax => syntax.ConstraintClauses,
                (parentSyntax, childSyntax) => parentSyntax.WithConstraintClauses(childSyntax));
            interfaces = new BaseTypeListWrapper<InterfaceTypeWithCodeAnalysis, InterfaceDeclarationSyntax>(
                node,
                (parentSyntax, childSyntax) => parentSyntax.WithBaseList(childSyntax));
            properties = new InterfaceMemberListWrapper<InterfacePropertyWithCodeAnalysis, PropertyDeclarationSyntax>(
                node,
                () => new InterfacePropertyWithCodeAnalysis());
            indexers = new InterfaceMemberListWrapper<InterfaceIndexerWithCodeAnalysis, IndexerDeclarationSyntax>(
                node,
                () => new InterfaceIndexerWithCodeAnalysis());
            methods = new InterfaceMemberListWrapper<InterfaceMethodWithCodeAnalysis, MethodDeclarationSyntax>(
                node,
                () => new InterfaceMethodWithCodeAnalysis());
            members = new MemberList<InterfaceTypeWithCodeAnalysis, InterfaceDeclarationSyntax>(
                node,
                (parentSyntax, childSyntax) => parentSyntax.WithMembers(childSyntax))
            {
                { nameof(events), () => events.Select(@event => @event.Syntax) },
                { nameof(properties), () => properties.Select(property => property.Syntax) },
                { nameof(indexers), () => indexers.Select(indexer => indexer.Syntax) },
                { nameof(methods), () => methods.Select(method => method.Syntax) }
            };
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { attributes.ReplaceList(value); }
        }
        
        public override ICollection<InterfaceEventWithCodeAnalysis> Events
        {
            get { return events; }
            set { members.CombineList(nameof(events), value.Select(item => item.Syntax)); }
        }

        public override IList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return genericParameters; }
            set { genericParameters.ReplaceList(value); }
        }

        public override ICollection<InterfaceIndexerWithCodeAnalysis> Indexers
        {
            get { return indexers; }
            set { members.CombineList(nameof(indexers), value.Select(item => item.Syntax)); }
        }

        public override ICollection<InterfaceReferenceWithCodeAnalysis> Interfaces
        {
            get { return interfaces; }
            set { interfaces.ReplaceList(value); }
        }

        public override ICollection<InterfaceMethodWithCodeAnalysis> Methods
        {
            get { return methods; }
            set { members.CombineList(nameof(methods), value.Select(item => item.Syntax)); }
        }

        public override string Name
        {
            get { return Syntax.Identifier.Text; }
            set { Syntax = Syntax.WithIdentifier(SyntaxFactory.Identifier(value)); }
        }

        public override ICollection<InterfacePropertyWithCodeAnalysis> Properties
        {
            get { return properties; }
            set { members.CombineList(nameof(properties), value.Select(item => item.Syntax)); }
        }

        public InterfaceDeclarationSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        public override bool IsPartial { get => Syntax.IsPartial(); set => Syntax = Syntax.IsPartial(value); }

        internal Node<InterfaceTypeWithCodeAnalysis, InterfaceDeclarationSyntax> Node
        {
            get { return node; }
        }
    }
}
