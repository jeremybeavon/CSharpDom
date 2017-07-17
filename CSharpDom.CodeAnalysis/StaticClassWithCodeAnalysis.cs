using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticClassWithCodeAnalysis :
        EditableStaticClass<
            NamespaceWithCodeAnalysis,
            DocumentWithCodeAnalysis,
            ProjectWithCodeAnalysis,
            SolutionWithCodeAnalysis,
            AttributeGroupWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            StaticClassEventCollectionWithCodeAnalysis,
            StaticClassPropertyWithCodeAnalysis,
            StaticClassMethodCollectionWithCodeAnalysis,
            StaticClassFieldCollectionWithCodeAnalysis,
            StaticClassNestedClassCollectionWithCodeAnalysis,
            StaticClassNestedDelegateWithCodeAnalysis,
            StaticClassNestedEnumWithCodeAnalysis,
            StaticClassNestedInterfaceWithCodeAnalysis,
            StaticClassNestedStructCollectionWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>,
        IHasSyntax<ClassDeclarationSyntax>,
        IHasNode<ClassDeclarationSyntax>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly DocumentWithCodeAnalysis document;
        private readonly Node<StaticClassWithCodeAnalysis, ClassDeclarationSyntax> node;
        private readonly AttributeListWrapper<StaticClassWithCodeAnalysis, ClassDeclarationSyntax> attributes;
        private readonly StaticClassNestedClassCollectionWithCodeAnalysis classes;
        private readonly StaticClassMemberListWrapper<
            StaticClassNestedDelegateWithCodeAnalysis,
            DelegateDeclarationSyntax> delegates;
        private readonly StaticClassMemberListWrapper<
            StaticClassNestedEnumWithCodeAnalysis,
            EnumDeclarationSyntax> enums;
        private readonly StaticClassEventCollectionWithCodeAnalysis events;
        private readonly StaticClassFieldCollectionWithCodeAnalysis fields;
        private readonly GenericParameterDeclarationListWrapper<
            StaticClassWithCodeAnalysis,
            ClassDeclarationSyntax> genericParameters;
        private readonly StaticClassMemberListWrapper<
            StaticClassNestedInterfaceWithCodeAnalysis,
            InterfaceDeclarationSyntax> interfaces;
        private readonly StaticClassMethodCollectionWithCodeAnalysis methods;
        private readonly StaticClassMemberListWrapper<
            StaticClassPropertyWithCodeAnalysis,
            PropertyDeclarationSyntax> properties;
        private readonly StaticClassMemberListWrapper<
            StaticConstructorWithCodeAnalysis,
            ConstructorDeclarationSyntax> staticConstructor;
        private readonly StaticClassNestedStructCollectionWithCodeAnalysis structs;
        private readonly MemberList<StaticClassWithCodeAnalysis, ClassDeclarationSyntax> members;

        internal StaticClassWithCodeAnalysis(DocumentWithCodeAnalysis document)
        {
            this.document = document;
            node = new Node<StaticClassWithCodeAnalysis, ClassDeclarationSyntax>(this);
            attributes = new AttributeListWrapper<StaticClassWithCodeAnalysis, ClassDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax));
            classes = new StaticClassNestedClassCollectionWithCodeAnalysis(this);
            delegates = new StaticClassMemberListWrapper<StaticClassNestedDelegateWithCodeAnalysis, DelegateDeclarationSyntax>(
                node,
                () => new StaticClassNestedDelegateWithCodeAnalysis());
            enums = new StaticClassMemberListWrapper<StaticClassNestedEnumWithCodeAnalysis, EnumDeclarationSyntax>(
                node,
                () => new StaticClassNestedEnumWithCodeAnalysis());
            events = new StaticClassEventCollectionWithCodeAnalysis(this);
            fields = new StaticClassFieldCollectionWithCodeAnalysis(this);
            genericParameters = new GenericParameterDeclarationListWrapper<StaticClassWithCodeAnalysis, ClassDeclarationSyntax>(
                node,
                syntax => syntax.TypeParameterList,
                (parentSyntax, childSyntax) => parentSyntax.WithTypeParameterList(childSyntax),
                syntax => syntax.ConstraintClauses,
                (parentSyntax, childSyntax) => parentSyntax.WithConstraintClauses(childSyntax));
            interfaces = new StaticClassMemberListWrapper<StaticClassNestedInterfaceWithCodeAnalysis, InterfaceDeclarationSyntax>(
                node,
                () => new StaticClassNestedInterfaceWithCodeAnalysis());
            methods = new StaticClassMethodCollectionWithCodeAnalysis(this);
            properties = new StaticClassMemberListWrapper<StaticClassPropertyWithCodeAnalysis, PropertyDeclarationSyntax>(
                node,
                () => new StaticClassPropertyWithCodeAnalysis());
            staticConstructor = new StaticClassMemberListWrapper<StaticConstructorWithCodeAnalysis, ConstructorDeclarationSyntax>(
                node,
                () => new StaticConstructorWithCodeAnalysis());
            structs = new StaticClassNestedStructCollectionWithCodeAnalysis(this);
            members = new MemberList<StaticClassWithCodeAnalysis, ClassDeclarationSyntax>(
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

        public override TypeVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToTypeVisibilityModifier(); }
            set
            {
                ClassDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithTypeVisibilityModifier(value));
            }
        }

        public ClassDeclarationSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        INode<ClassDeclarationSyntax> IHasNode<ClassDeclarationSyntax>.Node
        {
            get { return node; }
        }

        internal Node<StaticClassWithCodeAnalysis, ClassDeclarationSyntax> Node
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
