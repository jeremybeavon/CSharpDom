using CSharpDom.Editable.Partial;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class StaticPartialClassWithCodeAnalysis :
        EditableStaticPartialClass<
            NamespaceWithCodeAnalysis,
            DocumentWithCodeAnalysis,
            ProjectWithCodeAnalysis,
            SolutionWithCodeAnalysis,
            AttributeGroupWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            StaticPartialClassEventCollectionWithCodeAnalysis,
            StaticPartialClassPropertyWithCodeAnalysis,
            StaticPartialClassMethodCollectionWithCodeAnalysis,
            StaticPartialClassFieldCollectionWithCodeAnalysis,
            StaticPartialClassNestedClassCollectionWithCodeAnalysis,
            StaticPartialClassNestedDelegateWithCodeAnalysis,
            StaticPartialClassNestedEnumWithCodeAnalysis,
            StaticPartialClassNestedInterfaceWithCodeAnalysis,
            StaticPartialClassNestedStructCollectionWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>,
        IHasSyntax<ClassDeclarationSyntax>,
        IHasNode<ClassDeclarationSyntax>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly DocumentWithCodeAnalysis document;
        private readonly Node<StaticPartialClassWithCodeAnalysis, ClassDeclarationSyntax> node;
        private readonly AttributeListWrapper<StaticPartialClassWithCodeAnalysis, ClassDeclarationSyntax> attributes;
        private readonly StaticPartialClassNestedClassCollectionWithCodeAnalysis classes;
        private readonly StaticPartialClassMemberListWrapper<
            StaticPartialClassNestedDelegateWithCodeAnalysis,
            DelegateDeclarationSyntax> delegates;
        private readonly StaticPartialClassMemberListWrapper<
            StaticPartialClassNestedEnumWithCodeAnalysis,
            EnumDeclarationSyntax> enums;
        private readonly StaticPartialClassEventCollectionWithCodeAnalysis events;
        private readonly StaticPartialClassFieldCollectionWithCodeAnalysis fields;
        private readonly GenericParameterDeclarationListWrapper<
            StaticPartialClassWithCodeAnalysis,
            ClassDeclarationSyntax> genericParameters;
        private readonly StaticPartialClassMemberListWrapper<
            StaticPartialClassNestedInterfaceWithCodeAnalysis,
            InterfaceDeclarationSyntax> interfaces;
        private readonly StaticPartialClassMethodCollectionWithCodeAnalysis methods;
        private readonly StaticPartialClassMemberListWrapper<
            StaticPartialClassPropertyWithCodeAnalysis,
            PropertyDeclarationSyntax> properties;
        private readonly StaticPartialClassMemberListWrapper<
            StaticConstructorWithCodeAnalysis,
            ConstructorDeclarationSyntax> staticConstructor;
        private readonly StaticPartialClassNestedStructCollectionWithCodeAnalysis structs;
        private readonly MemberList<StaticPartialClassWithCodeAnalysis, ClassDeclarationSyntax> members;

        internal StaticPartialClassWithCodeAnalysis(DocumentWithCodeAnalysis document)
        {
            this.document = document;
            node = new Node<StaticPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(this);
            attributes = new AttributeListWrapper<StaticPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax));
            classes = new StaticPartialClassNestedClassCollectionWithCodeAnalysis(this);
            delegates = new StaticPartialClassMemberListWrapper<StaticPartialClassNestedDelegateWithCodeAnalysis, DelegateDeclarationSyntax>(
                node,
                () => new StaticPartialClassNestedDelegateWithCodeAnalysis());
            enums = new StaticPartialClassMemberListWrapper<StaticPartialClassNestedEnumWithCodeAnalysis, EnumDeclarationSyntax>(
                node,
                () => new StaticPartialClassNestedEnumWithCodeAnalysis());
            events = new StaticPartialClassEventCollectionWithCodeAnalysis(this);
            fields = new StaticPartialClassFieldCollectionWithCodeAnalysis(this);
            genericParameters = new GenericParameterDeclarationListWrapper<StaticPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                node,
                syntax => syntax.TypeParameterList,
                (parentSyntax, childSyntax) => parentSyntax.WithTypeParameterList(childSyntax),
                syntax => syntax.ConstraintClauses,
                (parentSyntax, childSyntax) => parentSyntax.WithConstraintClauses(childSyntax));
            interfaces = new StaticPartialClassMemberListWrapper<StaticPartialClassNestedInterfaceWithCodeAnalysis, InterfaceDeclarationSyntax>(
                node,
                () => new StaticPartialClassNestedInterfaceWithCodeAnalysis());
            methods = new StaticPartialClassMethodCollectionWithCodeAnalysis(this);
            properties = new StaticPartialClassMemberListWrapper<StaticPartialClassPropertyWithCodeAnalysis, PropertyDeclarationSyntax>(
                node,
                () => new StaticPartialClassPropertyWithCodeAnalysis());
            staticConstructor = new StaticPartialClassMemberListWrapper<StaticConstructorWithCodeAnalysis, ConstructorDeclarationSyntax>(
                node,
                () => new StaticConstructorWithCodeAnalysis());
            structs = new StaticPartialClassNestedStructCollectionWithCodeAnalysis(this);
            members = new MemberList<StaticPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
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

        public override StaticPartialClassNestedClassCollectionWithCodeAnalysis Classes
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

        public override ICollection<StaticPartialClassNestedEnumWithCodeAnalysis> Enums
        {
            get { return enums; }
            set { members.CombineList(nameof(Enums), value.Select(item => item.Syntax)); }
        }

        public override ICollection<StaticPartialClassNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return delegates; }
            set { members.CombineList(nameof(Delegates), value.Select(item => item.Syntax)); }
        }

        public override StaticPartialClassEventCollectionWithCodeAnalysis Events
        {
            get { return events; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(events.Events), value.Events.Select(item => item.Syntax)),
                    new MemberListSyntax(nameof(events.EventProperties), value.EventProperties.Select(item => item.Syntax)));
            }
        }

        public override StaticPartialClassFieldCollectionWithCodeAnalysis Fields
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

        public override ICollection<StaticPartialClassNestedInterfaceWithCodeAnalysis> Interfaces
        {
            get { return interfaces; }
            set { members.CombineList(nameof(Interfaces), value.Select(item => item.Syntax)); }
        }

        public override StaticPartialClassMethodCollectionWithCodeAnalysis Methods
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

        public override ICollection<StaticPartialClassPropertyWithCodeAnalysis> Properties
        {
            get { return properties; }
            set { members.CombineList(nameof(Properties), value.Select(item => item.Syntax)); }
        }

        public override StaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return staticConstructor.GetStaticConstructor(); }
            set { staticConstructor.SetStaticConstructor(value); }
        }

        public override StaticPartialClassNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return structs; }
            set { members.CombineList(nameof(structs.Structs), value.Structs.Select(item => item.Syntax)); }
        }

        public override DocumentWithCodeAnalysis Document
        {
            get { return document; }
            set { throw new NotSupportedException(); }
        }

        public override NamespaceWithCodeAnalysis Namespace
        {
            get { return node.GetParentNode<NamespaceWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override ProjectWithCodeAnalysis Project
        {
            get { return document.Project; }
            set { throw new NotSupportedException(); }
        }

        public override SolutionWithCodeAnalysis Solution
        {
            get { return document.Solution; }
            set { throw new NotSupportedException(); }
        }

        public ClassDeclarationSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        public override TypeVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToTypeVisibilityModifier(); }
            set
            {
                ClassDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithTypeVisibilityModifier(value));
            }
        }

        INode<ClassDeclarationSyntax> IHasNode<ClassDeclarationSyntax>.Node
        {
            get { return node; }
        }

        internal Node<StaticPartialClassWithCodeAnalysis, ClassDeclarationSyntax> Node
        {
            get { return node; }
        }

        internal IMemberList Members
        {
            get { return members; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitClassWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
