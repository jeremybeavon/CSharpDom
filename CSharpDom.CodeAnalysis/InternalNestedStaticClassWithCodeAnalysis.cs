using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalNestedStaticClassWithCodeAnalysis<TStaticClass> :
        NestedStaticClassWithCodeAnalysis
        where TStaticClass : class, IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly Node<TStaticClass, ClassDeclarationSyntax> node;
        private readonly AttributeListWrapper<TStaticClass, ClassDeclarationSyntax> attributes;
        private readonly NestedStaticClassNestedClassCollectionWithCodeAnalysis classes;
        private readonly ClassMemberListWrapper<
            TStaticClass,
            NestedStaticClassNestedDelegateWithCodeAnalysis,
            DelegateDeclarationSyntax> delegates;
        private readonly ClassMemberListWrapper<
            TStaticClass,
            NestedStaticClassNestedEnumWithCodeAnalysis,
            EnumDeclarationSyntax> enums;
        private readonly NestedStaticClassEventCollectionWithCodeAnalysis events;
        private readonly NestedStaticClassFieldCollectionWithCodeAnalysis fields;
        private readonly GenericParameterDeclarationListWrapper<TStaticClass, ClassDeclarationSyntax> genericParameters;
        private readonly ClassMemberListWrapper<
            TStaticClass,
            NestedStaticClassNestedInterfaceWithCodeAnalysis,
            InterfaceDeclarationSyntax> interfaces;
        private readonly NestedStaticClassMethodCollectionWithCodeAnalysis methods;
        private readonly ClassMemberListWrapper<
            TStaticClass,
            NestedStaticClassPropertyWithCodeAnalysis,
            PropertyDeclarationSyntax> properties;
        private readonly ClassMemberListWrapper<
            TStaticClass,
            StaticConstructorWithCodeAnalysis,
            ConstructorDeclarationSyntax> staticConstructor;
        private readonly NestedStaticClassNestedStructCollectionWithCodeAnalysis structs;
        private readonly MemberList<TStaticClass, ClassDeclarationSyntax> members;

        internal InternalNestedStaticClassWithCodeAnalysis(TStaticClass @class)
        {
            node = new Node<TStaticClass, ClassDeclarationSyntax>(@class);
            attributes = new AttributeListWrapper<TStaticClass, ClassDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax));
            classes = new InternalNestedStaticClassNestedClassCollectionWithCodeAnalysis<TStaticClass>(this);
            delegates = new ClassMemberListWrapper<TStaticClass, NestedStaticClassNestedDelegateWithCodeAnalysis, DelegateDeclarationSyntax>(
                node,
                () => new NestedStaticClassNestedDelegateWithCodeAnalysis());
            enums = new ClassMemberListWrapper<TStaticClass, NestedStaticClassNestedEnumWithCodeAnalysis, EnumDeclarationSyntax>(
                node,
                () => new NestedStaticClassNestedEnumWithCodeAnalysis());
            events = new InternalNestedStaticClassEventCollectionWithCodeAnalysis<TStaticClass>(this);
            fields = new InternalNestedStaticClassFieldCollectionWithCodeAnalysis<TStaticClass>(this);
            genericParameters = new GenericParameterDeclarationListWrapper<TStaticClass, ClassDeclarationSyntax>(
                node,
                syntax => syntax.TypeParameterList,
                (parentSyntax, childSyntax) => parentSyntax.WithTypeParameterList(childSyntax),
                syntax => syntax.ConstraintClauses,
                (parentSyntax, childSyntax) => parentSyntax.WithConstraintClauses(childSyntax));
            interfaces = new ClassMemberListWrapper<TStaticClass, NestedStaticClassNestedInterfaceWithCodeAnalysis, InterfaceDeclarationSyntax>(
                node,
                () => new NestedStaticClassNestedInterfaceWithCodeAnalysis());
            methods = new InternalNestedStaticClassMethodCollectionWithCodeAnalysis<TStaticClass>(this);
            properties = new ClassMemberListWrapper<TStaticClass, NestedStaticClassPropertyWithCodeAnalysis, PropertyDeclarationSyntax>(
                node,
                () => new NestedStaticClassPropertyWithCodeAnalysis());
            staticConstructor = new ClassMemberListWrapper<TStaticClass, StaticConstructorWithCodeAnalysis, ConstructorDeclarationSyntax>(
                node,
                () => new StaticConstructorWithCodeAnalysis());
            structs = new InternalNestedStaticClassNestedStructCollectionWithCodeAnalysis<TStaticClass>(this);
            members = new MemberList<TStaticClass, ClassDeclarationSyntax>(
                node,
                (parentSyntax, childSyntax) => parentSyntax.WithMembers(childSyntax))
            {
                { nameof(fields.Constants), () => fields.Constants.Select(item => item.Syntax) },
                { nameof(fields.Fields), () => fields.Fields.Select(item => item.Syntax) },
                { nameof(Enums), () => enums.Select(item => item.Syntax) },
                { nameof(Delegates), () => delegates.Select(item => item.Syntax) },
                { nameof(events.Events), () => events.Events.Select(item => item.Syntax) },
                { nameof(events.EventProperties), () => events.EventProperties.Select(item => item.Syntax) },
                { nameof(Interfaces), () => interfaces.Select(item => item.Syntax) },
                { nameof(Properties), () => Properties.Select(item => item.Syntax) },
                { nameof(methods.Methods), () => methods.Methods.Select(item => item.Syntax) }
            };
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { attributes.ReplaceList(value); }
        }

        public override NestedStaticClassNestedClassCollectionWithCodeAnalysis Classes
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

        public override ICollection<NestedStaticClassNestedEnumWithCodeAnalysis> Enums
        {
            get { return enums; }
            set { members.CombineList(nameof(Enums), value.Select(item => item.Syntax)); }
        }

        public override ICollection<NestedStaticClassNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return delegates; }
            set { members.CombineList(nameof(Delegates), value.Select(item => item.Syntax)); }
        }

        public override NestedStaticClassEventCollectionWithCodeAnalysis Events
        {
            get { return events; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(events.Events), value.Events.Select(item => item.Syntax)),
                    new MemberListSyntax(nameof(events.EventProperties), value.EventProperties.Select(item => item.Syntax)));
            }
        }

        public override NestedStaticClassFieldCollectionWithCodeAnalysis Fields
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

        public override ICollection<NestedStaticClassNestedInterfaceWithCodeAnalysis> Interfaces
        {
            get { return interfaces; }
            set { members.CombineList(nameof(Interfaces), value.Select(item => item.Syntax)); }
        }

        public override NestedStaticClassMethodCollectionWithCodeAnalysis Methods
        {
            get { return methods; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(methods.Methods), value.Methods.Select(item => item.Syntax)));
            }
        }

        public override string Name
        {
            get { return Syntax.Identifier.Text; }
            set { Syntax = Syntax.WithIdentifier(SyntaxFactory.Identifier(value)); }
        }

        public override ICollection<NestedStaticClassPropertyWithCodeAnalysis> Properties
        {
            get { return properties; }
            set { members.CombineList(nameof(Properties), value.Select(item => item.Syntax)); }
        }

        public override StaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return staticConstructor.GetStaticConstructor(); }
            set { staticConstructor.SetStaticConstructor(value); }
        }

        public override NestedStaticClassNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return structs; }
            set { members.CombineList(nameof(structs.Structs), value.Structs.Select(item => item.Syntax)); }
        }

        public override ClassDeclarationSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        public override IType DeclaringType
        {
            get { return node.GetParentNode<IType>(); }
            set { throw new NotSupportedException(); }
        }

        internal Node<TStaticClass, ClassDeclarationSyntax> Node
        {
            get { return node; }
        }

        internal IMemberList Members
        {
            get { return members; }
        }
    }
}