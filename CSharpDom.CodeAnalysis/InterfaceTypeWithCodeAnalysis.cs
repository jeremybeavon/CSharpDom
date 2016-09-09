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
        IHasSyntax<InterfaceDeclarationSyntax>,
        ISimpleMember
    {
        private readonly object @interface;
        private readonly Node<InterfaceTypeWithCodeAnalysis, InterfaceDeclarationSyntax> node;
        private readonly AttributeListWrapper<InterfaceTypeWithCodeAnalysis, InterfaceDeclarationSyntax> attributes;
        private readonly InterfaceMemberListWrapper<
            EventWithCodeAnalysis,
            InterfaceEventWithCodeAnalysis,
            EventFieldDeclarationSyntax> events;
        private readonly GenericParameterDeclarationListWrapper<InterfaceTypeWithCodeAnalysis, InterfaceDeclarationSyntax> genericParameters;
        private readonly BaseTypeListWrapper<InterfaceTypeWithCodeAnalysis, InterfaceDeclarationSyntax> interfaces;
        private readonly InterfaceMemberListWrapper<
            PropertyWithCodeAnalysis,
            InterfacePropertyWithCodeAnalysis,
            PropertyDeclarationSyntax> properties;
        private readonly InterfaceMemberListWrapper<
            IndexerWithCodeAnalysis,
            InterfaceIndexerWithCodeAnalysis,
            IndexerDeclarationSyntax> indexers;
        private readonly InterfaceMemberListWrapper<
            MethodWithCodeAnalysis,
            InterfaceMethodWithCodeAnalysis,
            MethodDeclarationSyntax> methods;
        private readonly MemberList<InterfaceTypeWithCodeAnalysis, InterfaceDeclarationSyntax> members;

        internal InterfaceTypeWithCodeAnalysis(ClassTypeWithCodeAnalysis parent, ClassNestedInterfaceWithCodeAnalysis @interface)
            : this(@interface)
        {
            ClassParent = parent;
        }

        internal InterfaceTypeWithCodeAnalysis(StaticTypeWithCodeAnalysis parent, StaticClassNestedInterfaceWithCodeAnalysis @interface)
            : this(@interface)
        {
            StaticClassParent = parent;
        }

        internal InterfaceTypeWithCodeAnalysis(StructTypeWithCodeAnalysis parent, StructNestedInterfaceWithCodeAnalysis @interface)
            : this(@interface)
        {
            StructParent = parent;
        }

        private InterfaceTypeWithCodeAnalysis(object @interface)
        {
            node = new Node<InterfaceTypeWithCodeAnalysis, InterfaceDeclarationSyntax>(this);
            this.@interface = @interface;
            attributes = new AttributeListWrapper<InterfaceTypeWithCodeAnalysis, InterfaceDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax),
                parent => new AttributeGroupWithCodeAnalysis(parent),
                (child, parent) => child.InterfaceParent = parent);
            events = new InterfaceMemberListWrapper<EventWithCodeAnalysis, InterfaceEventWithCodeAnalysis, EventFieldDeclarationSyntax>(
                node,
                parent => new InterfaceEventWithCodeAnalysis(parent),
                (child, parent) => child.Event.InterfaceParent = parent);
            genericParameters = new GenericParameterDeclarationListWrapper<InterfaceTypeWithCodeAnalysis, InterfaceDeclarationSyntax>(
                node,
                syntax => syntax.TypeParameterList,
                (parentSyntax, childSyntax) => parentSyntax.WithTypeParameterList(childSyntax),
                syntax => syntax.ConstraintClauses,
                (parentSyntax, childSyntax) => parentSyntax.WithConstraintClauses(childSyntax),
                parent => new GenericParameterDeclarationWithCodeAnalysis(parent),
                (child, parent) => child.InterfaceParent = parent);
            interfaces = new BaseTypeListWrapper<InterfaceTypeWithCodeAnalysis, InterfaceDeclarationSyntax>(
                node,
                (parentSyntax, childSyntax) => parentSyntax.WithBaseList(childSyntax),
                parent => null,
                null);
            properties = new InterfaceMemberListWrapper<PropertyWithCodeAnalysis, InterfacePropertyWithCodeAnalysis, PropertyDeclarationSyntax>(
                node,
                parent => new InterfacePropertyWithCodeAnalysis(parent),
                (child, parent) => child.Property.InterfaceParent = parent);
            indexers = new InterfaceMemberListWrapper<IndexerWithCodeAnalysis, InterfaceIndexerWithCodeAnalysis, IndexerDeclarationSyntax>(
                node,
                parent => new InterfaceIndexerWithCodeAnalysis(parent),
                (child, parent) => child.Indexer.InterfaceParent = parent);
            methods = new InterfaceMemberListWrapper<MethodWithCodeAnalysis, InterfaceMethodWithCodeAnalysis, MethodDeclarationSyntax>(
                node,
                parent => new InterfaceMethodWithCodeAnalysis(parent),
                (child, parent) => child.Method.InterfaceParent = parent);
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

        internal IAttributeCollection AttributeList
        {
            get { return attributes; }
        }

        internal IChildCollection<EventWithCodeAnalysis, EventFieldDeclarationSyntax> EventList
        {
            get { return events; }
        }

        internal IGenericParameterCollection GenericParameterList
        {
            get { return genericParameters; }
        }

        internal IChildCollection<IndexerWithCodeAnalysis, IndexerDeclarationSyntax> IndexerList
        {
            get { return indexers; }
        }

        internal IChildCollection<MethodWithCodeAnalysis, MethodDeclarationSyntax> MethodList
        {
            get { return methods; }
        }

        internal IChildCollection<PropertyWithCodeAnalysis, PropertyDeclarationSyntax> PropertyList
        {
            get { return properties; }
        }

        internal ClassTypeWithCodeAnalysis ClassParent
        {
            get { return node.GetParentNode<ClassTypeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                    value,
                    parent => parent.Interfaces.InterfaceList);
            }
        }

        internal StaticTypeWithCodeAnalysis StaticClassParent
        {
            get { return node.GetParentNode<StaticTypeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<StaticTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                    value,
                    parent => parent.Interfaces.InterfaceList);
            }
        }

        internal StructTypeWithCodeAnalysis StructParent
        {
            get { return node.GetParentNode<StructTypeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<StructTypeWithCodeAnalysis, StructDeclarationSyntax>(
                    value,
                    parent => parent.Interfaces.InterfaceList);
            }
        }

        T ISimpleMember.Member<T>()
        {
            return (T)@interface;
        }
    }
}
