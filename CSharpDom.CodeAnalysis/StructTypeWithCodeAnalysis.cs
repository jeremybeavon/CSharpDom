using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructTypeWithCodeAnalysis :
        EditableStructType<
            AttributeGroupWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            StructEventCollectionWithCodeAnalysis,
            StructPropertyCollectionWithCodeAnalysis,
            StructIndexerCollectionWithCodeAnalysis,
            StructMethodCollectionWithCodeAnalysis,
            StructFieldCollectionWithCodeAnalysis,
            StructConstructorWithCodeAnalysis,
            OperatorOverloadWithCodeAnalysis,
            ConversionOperatorWithCodeAnalysis,
            StructNestedClassCollectionWithCodeAnalysis,
            IStructNestedDelegate,
            StructNestedEnumWithCodeAnalysis,
            IStructNestedInterfaceCollection,
            StructNestedStructCollectionWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>,
        IHasSyntax<StructDeclarationSyntax>,
        ISimpleMember
    {
        private readonly object @struct;
        private readonly Node<StructTypeWithCodeAnalysis, StructDeclarationSyntax> node;
        private readonly AttributeListWrapper<StructTypeWithCodeAnalysis, StructDeclarationSyntax> attributes;
        private readonly StructNestedClassCollectionWithCodeAnalysis classes;
        private readonly StructTypeMemberListWrapper<
            ConstructorWithCodeAnalysis,
            StructConstructorWithCodeAnalysis,
            ConstructorDeclarationSyntax> constructors;
        private readonly SimpleStructMemberListWrapper<
            ConversionOperatorWithCodeAnalysis,
            ConversionOperatorDeclarationSyntax> conversionOperators;
        private readonly StructTypeMemberListWrapper<
            NestedEnumWithCodeAnalysis,
            StructNestedEnumWithCodeAnalysis,
            EnumDeclarationSyntax> enums;
        private readonly StructEventCollectionWithCodeAnalysis events;
        private readonly StructFieldCollectionWithCodeAnalysis fields;
        private readonly GenericParameterDeclarationListWrapper<StructTypeWithCodeAnalysis, StructDeclarationSyntax> genericParameters;
        private readonly StructIndexerCollectionWithCodeAnalysis indexers;
        private readonly StructMethodCollectionWithCodeAnalysis methods;
        private readonly SimpleStructMemberListWrapper<
            OperatorOverloadWithCodeAnalysis,
            OperatorDeclarationSyntax> operatorOverloads;
        private readonly StructPropertyCollectionWithCodeAnalysis properties;
        private readonly SimpleStructMemberListWrapper<
            StaticConstructorWithCodeAnalysis,
            ConstructorDeclarationSyntax> staticConstructor;
        private readonly StructNestedStructCollectionWithCodeAnalysis structs;
        private readonly MemberList<StructTypeWithCodeAnalysis, StructDeclarationSyntax> members;

        private StructTypeWithCodeAnalysis(object @struct)
        {
            node = new Node<StructTypeWithCodeAnalysis, StructDeclarationSyntax>(this);
            this.@struct = @struct;
            attributes = new AttributeListWrapper<StructTypeWithCodeAnalysis, StructDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax),
                parent => new AttributeGroupWithCodeAnalysis(parent),
                (child, parent) => child.StructParent = parent);
            classes = new StructNestedClassCollectionWithCodeAnalysis(this);
            constructors = new StructTypeMemberListWrapper<ConstructorWithCodeAnalysis, StructConstructorWithCodeAnalysis, ConstructorDeclarationSyntax>(
                node,
                parent => new StructConstructorWithCodeAnalysis(parent),
                (child, parent) => child.Constructor.StructParent = parent,
                syntax => !syntax.IsStatic());
            conversionOperators = new SimpleStructMemberListWrapper<ConversionOperatorWithCodeAnalysis, ConversionOperatorDeclarationSyntax>(
                node,
                parent => new ConversionOperatorWithCodeAnalysis(parent),
                (child, parent) => child.StructParent = parent);
            enums = new StructTypeMemberListWrapper<NestedEnumWithCodeAnalysis, StructNestedEnumWithCodeAnalysis, EnumDeclarationSyntax>(
                node,
                parent => new StructNestedEnumWithCodeAnalysis(parent),
                (child, parent) => child.Enum.StructParent = parent);
            events = new StructEventCollectionWithCodeAnalysis(this);
            fields = new StructFieldCollectionWithCodeAnalysis(this);
            genericParameters = new GenericParameterDeclarationListWrapper<StructTypeWithCodeAnalysis, StructDeclarationSyntax>(
                node,
                syntax => syntax.TypeParameterList,
                (parentSyntax, childSyntax) => parentSyntax.WithTypeParameterList(childSyntax),
                syntax => syntax.ConstraintClauses,
                (parentSyntax, childSyntax) => parentSyntax.WithConstraintClauses(childSyntax),
                parent => new GenericParameterDeclarationWithCodeAnalysis(parent),
                (child, parent) => child.StructParent = parent);
            indexers = new StructIndexerCollectionWithCodeAnalysis(this);
            methods = new StructMethodCollectionWithCodeAnalysis(this);
            operatorOverloads = new SimpleStructMemberListWrapper<OperatorOverloadWithCodeAnalysis, OperatorDeclarationSyntax>(
                node,
                parent => new OperatorOverloadWithCodeAnalysis(parent),
                (child, parent) => child.StructParent = parent);
            properties = new StructPropertyCollectionWithCodeAnalysis(this);
            staticConstructor = new SimpleStructMemberListWrapper<StaticConstructorWithCodeAnalysis, ConstructorDeclarationSyntax>(
                node,
                parent => new StaticConstructorWithCodeAnalysis(parent),
                (child, parent) => child.StructParent = parent,
                syntax => syntax.IsStatic());
            structs = new StructNestedStructCollectionWithCodeAnalysis(this);
            members = new MemberList<StructTypeWithCodeAnalysis, StructDeclarationSyntax>(
                node,
                (parentSyntax, childSyntax) => parentSyntax.WithMembers(childSyntax))
            {
                { nameof(fields.Constants), () => fields.Constants.Select(item => item.Syntax) },
                { nameof(fields.Fields), () => fields.Fields.Select(item => item.Syntax) },
                { nameof(Enums), () => enums.Select(item => item.Syntax) },
                { nameof(events.Events), () => events.Events.Select(item => item.Syntax) },
                { nameof(events.EventProperties), () => events.EventProperties.Select(item => item.Syntax) },
                { nameof(events.ExplicitInterfaceEvents), () => events.ExplicitInterfaceEvents.Select(item => item.Syntax) },
                { nameof(Constructors), () => constructors.Select(item => item.Syntax) },
                { nameof(properties.Properties), () => properties.Properties.Select(item => item.Syntax) },
                { nameof(properties.ExplicitInterfaceProperties), () => properties.ExplicitInterfaceProperties.Select(item => item.Syntax) },
                { nameof(indexers.Indexers), () => indexers.Indexers.Select(item => item.Syntax) },
                { nameof(indexers.ExplicitInterfaceIndexers), () => indexers.ExplicitInterfaceIndexers.Select(item => item.Syntax) },
                { nameof(methods.Methods), () => methods.Methods.Select(item => item.Syntax) },
                { nameof(methods.ExplicitInterfaceMethods), () => methods.ExplicitInterfaceMethods.Select(item => item.Syntax) },
                { nameof(OperatorOverloads), () => operatorOverloads.Select(item => item.Syntax) },
                { nameof(ConversionOperators), () => conversionOperators.Select(item => item.Syntax) },
            };
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { attributes.ReplaceList(value); }
        }

        public override ICollection<StructConstructorWithCodeAnalysis> Constructors
        {
            get { return constructors; }
            set { members.CombineList(nameof(Constructors), constructors.Select(item => item.Syntax)); }
        }

        public override ICollection<ConversionOperatorWithCodeAnalysis> ConversionOperators
        {
            get { return conversionOperators; }
            set { members.CombineList(nameof(ConversionOperators), conversionOperators.Select(item => item.Syntax)); }
        }

        public override ICollection<StructNestedEnumWithCodeAnalysis> Enums
        {
            get { return enums; }
            set { members.CombineList(nameof(Enums), enums.Select(item => item.Syntax)); }
        }

        public override StructEventCollectionWithCodeAnalysis Events
        {
            get { return events; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(events.Events), value.Events.Select(item => item.Syntax)),
                    new MemberListSyntax(nameof(events.EventProperties), value.EventProperties.Select(item => item.Syntax)),
                    new MemberListSyntax(nameof(events.ExplicitInterfaceEvents), value.ExplicitInterfaceEvents.Select(item => item.Syntax)));
            }
        }

        public override StructFieldCollectionWithCodeAnalysis Fields
        {
            get { return fields; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(fields.Constants), value.Constants.Select(item => item.Syntax)),
                    new MemberListSyntax(nameof(fields.Fields), value.Fields.Select(item => item.Syntax)));
            }
        }

        public override IList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return genericParameters; }
            set { genericParameters.ReplaceList(value); }
        }

        public override StructIndexerCollectionWithCodeAnalysis Indexers
        {
            get { return indexers; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(indexers.Indexers), value.Indexers.Select(item => item.Syntax)),
                    new MemberListSyntax(nameof(indexers.ExplicitInterfaceIndexers), value.ExplicitInterfaceIndexers.Select(item => item.Syntax)));
            }
        }

        public override StructMethodCollectionWithCodeAnalysis Methods
        {
            get { return methods; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(methods.Methods), value.Methods.Select(item => item.Syntax)),
                    new MemberListSyntax(nameof(methods.ExplicitInterfaceMethods), value.ExplicitInterfaceMethods.Select(item => item.Syntax)));
            }
        }

        public override string Name
        {
            get { return Syntax.Identifier.Text; }
            set { Syntax = Syntax.WithIdentifier(SyntaxFactory.Identifier(value)); }
        }

        public override ICollection<OperatorOverloadWithCodeAnalysis> OperatorOverloads
        {
            get { return operatorOverloads; }
            set { members.CombineList(nameof(OperatorOverloads), value.Select(item => item.Syntax)); }
        }

        public override StructPropertyCollectionWithCodeAnalysis Properties
        {
            get { return properties; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(properties.Properties), value.Properties.Select(item => item.Syntax)),
                    new MemberListSyntax(nameof(properties.ExplicitInterfaceProperties), value.Properties.Select(item => item.Syntax)));
            }
        }

        public StructDeclarationSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        internal Node<StructTypeWithCodeAnalysis, StructDeclarationSyntax> Node
        {
            get { return node; }
        }

        internal MemberList<StructTypeWithCodeAnalysis, StructDeclarationSyntax> Members
        {
            get { return members; }
        }

        internal IAttributeCollection AttributeList
        {
            get { return attributes; }
        }

        internal IChildCollection<ConversionOperatorWithCodeAnalysis, ConversionOperatorDeclarationSyntax> ConversionOperatorList
        {
            get { return conversionOperators; }
        }

        internal IChildCollection<ConstructorWithCodeAnalysis, ConstructorDeclarationSyntax> ConstructorList
        {
            get { return constructors; }
        }

        internal IChildCollection<NestedEnumWithCodeAnalysis, EnumDeclarationSyntax> EnumList
        {
            get { return enums; }
        }

        internal IGenericParameterCollection GenericParameterList
        {
            get { return genericParameters; }
        }

        internal IChildCollection<OperatorOverloadWithCodeAnalysis, OperatorDeclarationSyntax> OperatorOverloadList
        {
            get { return operatorOverloads; }
        }

        internal IChildCollection<StaticConstructorWithCodeAnalysis, ConstructorDeclarationSyntax> StaticConstructorList
        {
            get { return staticConstructor; }
        }

        T ISimpleMember.Member<T>()
        {
            return (T)@struct;
        }
    }
}
