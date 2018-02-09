using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalStaticTypeWithCodeAnalysis<TClass> : StaticTypeWithCodeAnalysis
        where TClass : class, IHasNode<ClassDeclarationSyntax>
    {
        private readonly Node<TClass, ClassDeclarationSyntax> node;
        private readonly AttributeListWrapper<TClass, ClassDeclarationSyntax> attributes;
        private readonly StaticClassNestedClassCollectionWithCodeAnalysis classes;
        private readonly ClassMemberListWrapper<
            TClass,
            StaticClassNestedDelegateWithCodeAnalysis,
            DelegateDeclarationSyntax> delegates;
        private readonly ClassMemberListWrapper<
            TClass,
            StaticClassNestedEnumWithCodeAnalysis,
            EnumDeclarationSyntax> enums;
        private readonly StaticClassEventCollectionWithCodeAnalysis events;
        private readonly StaticClassFieldCollectionWithCodeAnalysis fields;
        private readonly GenericParameterDeclarationNodeList<
            TClass,
            ClassDeclarationSyntax> genericParameters;
        private readonly ClassMemberListWrapper<
            TClass,
            StaticClassNestedInterfaceWithCodeAnalysis,
            InterfaceDeclarationSyntax> interfaces;
        private readonly StaticClassMethodCollectionWithCodeAnalysis methods;
        private readonly ClassMemberListWrapper<
            TClass,
            StaticClassPropertyWithCodeAnalysis,
            PropertyDeclarationSyntax> properties;
        private readonly ClassMemberListWrapper<
            TClass,
            StaticConstructorWithCodeAnalysis,
            ConstructorDeclarationSyntax> staticConstructor;
        private readonly StaticClassNestedStructCollectionWithCodeAnalysis structs;
        private readonly MemberList<TClass, ClassDeclarationSyntax> members;

        public InternalStaticTypeWithCodeAnalysis(TClass @class)
        {
            node = new Node<TClass, ClassDeclarationSyntax>(@class);
            attributes = new AttributeListWrapper<TClass, ClassDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax));
            classes = new InternalStaticClassNestedClassCollectionWithCodeAnalysis<TClass>(this);
            delegates = new ClassMemberListWrapper<TClass, StaticClassNestedDelegateWithCodeAnalysis, DelegateDeclarationSyntax>(
                node,
                () => new StaticClassNestedDelegateWithCodeAnalysis());
            enums = new ClassMemberListWrapper<TClass, StaticClassNestedEnumWithCodeAnalysis, EnumDeclarationSyntax>(
                node,
                () => new StaticClassNestedEnumWithCodeAnalysis());
            events = new InternalStaticClassEventCollectionWithCodeAnalysis<TClass>(this);
            fields = new InternalStaticClassFieldCollectionWithCodeAnalysis<TClass>(this);
            genericParameters = new GenericParameterDeclarationNodeList<TClass, ClassDeclarationSyntax>(
                node,
                syntax => syntax.TypeParameterList,
                (parentSyntax, childSyntax) => parentSyntax.WithTypeParameterList(childSyntax),
                syntax => syntax.ConstraintClauses,
                (parentSyntax, childSyntax) => parentSyntax.WithConstraintClauses(childSyntax));
            interfaces = new ClassMemberListWrapper<TClass, StaticClassNestedInterfaceWithCodeAnalysis, InterfaceDeclarationSyntax>(
                node,
                () => new StaticClassNestedInterfaceWithCodeAnalysis());
            methods = new InternalStaticClassMethodCollectionWithCodeAnalysis<TClass>(this);
            properties = new ClassMemberListWrapper<TClass, StaticClassPropertyWithCodeAnalysis, PropertyDeclarationSyntax>(
                node,
                () => new StaticClassPropertyWithCodeAnalysis());
            staticConstructor = new ClassMemberListWrapper<TClass, StaticConstructorWithCodeAnalysis, ConstructorDeclarationSyntax>(
                node,
                () => new StaticConstructorWithCodeAnalysis());
            structs = new InternalStaticClassNestedStructCollectionWithCodeAnalysis<TClass>(this);
            members = new MemberList<TClass, ClassDeclarationSyntax>(
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
                { nameof(methods.ExtensionMethods), () => methods.ExtensionMethods.Select(item => item.Syntax) },
                { nameof(methods.Methods), () => methods.Methods.Select(item => item.Syntax) }
            };
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { attributes.ReplaceList(value); }
        }

        public override StaticClassNestedClassCollectionWithCodeAnalysis Classes
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

        public override ICollection<StaticClassNestedEnumWithCodeAnalysis> Enums
        {
            get { return enums; }
            set { members.CombineList(nameof(Enums), value.Select(item => item.Syntax)); }
        }

        public override ICollection<StaticClassNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return delegates; }
            set { members.CombineList(nameof(Delegates), value.Select(item => item.Syntax)); }
        }

        public override StaticClassEventCollectionWithCodeAnalysis Events
        {
            get { return events; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(events.Events), value.Events.Select(item => item.Syntax)),
                    new MemberListSyntax(nameof(events.EventProperties), value.EventProperties.Select(item => item.Syntax)));
            }
        }

        public override StaticClassFieldCollectionWithCodeAnalysis Fields
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

        public override ICollection<StaticClassNestedInterfaceWithCodeAnalysis> Interfaces
        {
            get { return interfaces; }
            set { members.CombineList(nameof(Interfaces), value.Select(item => item.Syntax)); }
        }

        public override StaticClassMethodCollectionWithCodeAnalysis Methods
        {
            get { return methods; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(methods.ExtensionMethods), value.ExtensionMethods.Select(item => item.Syntax)),
                    new MemberListSyntax(nameof(methods.Methods), value.Methods.Select(item => item.Syntax)));
            }
        }

        public override string Name
        {
            get { return Syntax.Identifier.Text; }
            set { Syntax = Syntax.WithIdentifier(SyntaxFactory.Identifier(value)); }
        }

        public override ICollection<StaticClassPropertyWithCodeAnalysis> Properties
        {
            get { return properties; }
            set { members.CombineList(nameof(Properties), value.Select(item => item.Syntax)); }
        }

        public override StaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return staticConstructor.GetStaticConstructor(); }
            set { staticConstructor.SetStaticConstructor(value); }
        }

        public override StaticClassNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return structs; }
            set { members.CombineList(nameof(structs.Structs), value.Structs.Select(item => item.Syntax)); }
        }

        public override ClassDeclarationSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        internal override INode<ClassDeclarationSyntax> Node => node;

        internal Node<TClass, ClassDeclarationSyntax> InternalNode => node;

        internal override IMemberList Members => members;
    }
}
