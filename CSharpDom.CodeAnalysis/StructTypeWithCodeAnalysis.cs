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
            StructNestedDelegateWithCodeAnalysis,
            StructNestedEnumWithCodeAnalysis,
            StructNestedInterfaceWithCodeAnalysis,
            StructNestedStructCollectionWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>,
        IHasSyntax<StructDeclarationSyntax>
    {
        private readonly Node<StructTypeWithCodeAnalysis, StructDeclarationSyntax> node;
        private readonly AttributeListWrapper<StructTypeWithCodeAnalysis, StructDeclarationSyntax> attributes;
        private readonly StructNestedClassCollectionWithCodeAnalysis classes;
        private readonly StructTypeMemberListWrapper<StructConstructorWithCodeAnalysis, ConstructorDeclarationSyntax> constructors;
        private readonly StructTypeMemberListWrapper<
            ConversionOperatorWithCodeAnalysis,
            ConversionOperatorDeclarationSyntax> conversionOperators;
        private readonly StructTypeMemberListWrapper<StructNestedDelegateWithCodeAnalysis, DelegateDeclarationSyntax> delegates;
        private readonly StructTypeMemberListWrapper<StructNestedEnumWithCodeAnalysis, EnumDeclarationSyntax> enums;
        private readonly StructEventCollectionWithCodeAnalysis events;
        private readonly StructFieldCollectionWithCodeAnalysis fields;
        private readonly GenericParameterDeclarationListWrapper<StructTypeWithCodeAnalysis, StructDeclarationSyntax> genericParameters;
        private readonly StructIndexerCollectionWithCodeAnalysis indexers;
        private readonly BaseTypeListWrapper<StructTypeWithCodeAnalysis, StructDeclarationSyntax> implementedInterfaces;
        private readonly StructTypeMemberListWrapper<StructNestedInterfaceWithCodeAnalysis, InterfaceDeclarationSyntax> interfaces;
        private readonly StructMethodCollectionWithCodeAnalysis methods;
        private readonly StructTypeMemberListWrapper<OperatorOverloadWithCodeAnalysis, OperatorDeclarationSyntax> operatorOverloads;
        private readonly StructPropertyCollectionWithCodeAnalysis properties;
        private readonly StructTypeMemberListWrapper<
            StaticConstructorWithCodeAnalysis,
            ConstructorDeclarationSyntax> staticConstructor;
        private readonly StructNestedStructCollectionWithCodeAnalysis structs;
        private readonly MemberList<StructTypeWithCodeAnalysis, StructDeclarationSyntax> members;

        internal StructTypeWithCodeAnalysis()
        {
            node = new Node<StructTypeWithCodeAnalysis, StructDeclarationSyntax>(this);
            attributes = new AttributeListWrapper<StructTypeWithCodeAnalysis, StructDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax));
            classes = new StructNestedClassCollectionWithCodeAnalysis(this);
            constructors = new StructTypeMemberListWrapper<StructConstructorWithCodeAnalysis, ConstructorDeclarationSyntax>(
                node,
                () => new StructConstructorWithCodeAnalysis(),
                syntax => !syntax.IsStatic());
            conversionOperators = new StructTypeMemberListWrapper<ConversionOperatorWithCodeAnalysis, ConversionOperatorDeclarationSyntax>(
                node,
                () => new ConversionOperatorWithCodeAnalysis());
            delegates = new StructTypeMemberListWrapper<StructNestedDelegateWithCodeAnalysis, DelegateDeclarationSyntax>(
                node,
                () => new StructNestedDelegateWithCodeAnalysis());
            enums = new StructTypeMemberListWrapper<StructNestedEnumWithCodeAnalysis, EnumDeclarationSyntax>(
                node,
                () => new StructNestedEnumWithCodeAnalysis());
            events = new StructEventCollectionWithCodeAnalysis(this);
            fields = new StructFieldCollectionWithCodeAnalysis(this);
            genericParameters = new GenericParameterDeclarationListWrapper<StructTypeWithCodeAnalysis, StructDeclarationSyntax>(
                node,
                syntax => syntax.TypeParameterList,
                (parentSyntax, childSyntax) => parentSyntax.WithTypeParameterList(childSyntax),
                syntax => syntax.ConstraintClauses,
                (parentSyntax, childSyntax) => parentSyntax.WithConstraintClauses(childSyntax));
            implementedInterfaces = new BaseTypeListWrapper<StructTypeWithCodeAnalysis, StructDeclarationSyntax>(
                node,
                (parentSyntax, childSyntax) => parentSyntax.WithBaseList(childSyntax));
            indexers = new StructIndexerCollectionWithCodeAnalysis(this);
            interfaces = new StructTypeMemberListWrapper<StructNestedInterfaceWithCodeAnalysis, InterfaceDeclarationSyntax>(
                node,
                () => new StructNestedInterfaceWithCodeAnalysis());
            methods = new StructMethodCollectionWithCodeAnalysis(this);
            operatorOverloads = new StructTypeMemberListWrapper<OperatorOverloadWithCodeAnalysis, OperatorDeclarationSyntax>(
                node,
                () => new OperatorOverloadWithCodeAnalysis());
            properties = new StructPropertyCollectionWithCodeAnalysis(this);
            staticConstructor = new StructTypeMemberListWrapper<StaticConstructorWithCodeAnalysis, ConstructorDeclarationSyntax>(
                node,
                () => new StaticConstructorWithCodeAnalysis(),
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

        public override StructNestedClassCollectionWithCodeAnalysis Classes
        {
            get { return classes; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(classes.Classes), value.Classes.Select(item => item.Syntax)),
                    new MemberListSyntax(nameof(classes.AbstractClasses), value.AbstractClasses.Select(item => item.Syntax)),
                    new MemberListSyntax(nameof(classes.SealedClasses), value.SealedClasses.Select(item => item.Syntax)),
                    new MemberListSyntax(nameof(classes.StaticClasses), value.StaticClasses.Select(item => item.Syntax)));
            }
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

        public override ICollection<StructNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return delegates; }
            set { members.CombineList(nameof(Delegates), delegates.Select(item => item.Syntax)); }
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

        public override ICollection<InterfaceReferenceWithCodeAnalysis> ImplementedInterfaces
        {
            get { return implementedInterfaces; }
            set { implementedInterfaces.ReplaceList(value); }
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

        public override ICollection<StructNestedInterfaceWithCodeAnalysis> Interfaces
        {
            get { return interfaces; }
            set { members.CombineList(nameof(Interfaces), interfaces.Select(item => item.Syntax)); }
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

        public override StaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return staticConstructor.GetStaticConstructor(); }
            set { staticConstructor.SetStaticConstructor(value); }
        }

        public override StructNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return structs; }
            set { members.CombineList(nameof(structs.Structs), value.Structs.Select(item => item.Syntax)); }
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
    }
}
