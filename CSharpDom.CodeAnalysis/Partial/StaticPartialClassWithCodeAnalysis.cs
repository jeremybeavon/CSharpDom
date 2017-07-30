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
        private readonly StaticClassWithCodeAnalysis classType;
        private readonly StaticPartialClassNestedClassCollectionWithCodeAnalysis classes;
        private readonly WrappedCollection<
            StaticClassNestedDelegateWithCodeAnalysis,
            StaticPartialClassNestedDelegateWithCodeAnalysis> delegates;
        private readonly WrappedCollection<
            StaticClassNestedEnumWithCodeAnalysis,
            StaticPartialClassNestedEnumWithCodeAnalysis> enums;
        private readonly StaticPartialClassEventCollectionWithCodeAnalysis events;
        private readonly StaticPartialClassFieldCollectionWithCodeAnalysis fields;
        private readonly WrappedCollection<
            StaticClassNestedInterfaceWithCodeAnalysis,
            StaticPartialClassNestedInterfaceWithCodeAnalysis> interfaces;
        private readonly StaticPartialClassMethodCollectionWithCodeAnalysis methods;
        private readonly WrappedCollection<
            StaticClassPropertyWithCodeAnalysis,
            StaticPartialClassPropertyWithCodeAnalysis> properties;
        private readonly StaticPartialClassNestedStructCollectionWithCodeAnalysis structs;
        private readonly IMemberList members;

        internal StaticPartialClassWithCodeAnalysis(DocumentWithCodeAnalysis document)
        {
            this.document = document;
            var type = new InternalStaticTypeWithCodeAnalysis<StaticPartialClassWithCodeAnalysis>(this);
            classType = new StaticClassWithCodeAnalysis(document, type);
            classes = new StaticPartialClassNestedClassCollectionWithCodeAnalysis(classType.Classes);
            delegates = new WrappedCollection<StaticClassNestedDelegateWithCodeAnalysis, StaticPartialClassNestedDelegateWithCodeAnalysis>(
                classType.Delegates,
                parent => new StaticPartialClassNestedDelegateWithCodeAnalysis(parent),
                child => child.Delegate,
                value => classType.Delegates = value);
            enums = new WrappedCollection<StaticClassNestedEnumWithCodeAnalysis, StaticPartialClassNestedEnumWithCodeAnalysis>(
                classType.Enums,
                parent => new StaticPartialClassNestedEnumWithCodeAnalysis(parent),
                child => child.Enum,
                value => classType.Enums = value);
            events = new StaticPartialClassEventCollectionWithCodeAnalysis(classType.Events);
            fields = new StaticPartialClassFieldCollectionWithCodeAnalysis(classType.Fields);
            interfaces = new WrappedCollection<StaticClassNestedInterfaceWithCodeAnalysis, StaticPartialClassNestedInterfaceWithCodeAnalysis>(
                classType.Interfaces,
                parent => new StaticPartialClassNestedInterfaceWithCodeAnalysis(parent),
                child => child.Interface,
                value => classType.Interfaces = value);
            methods = new StaticPartialClassMethodCollectionWithCodeAnalysis(type);
            properties = new WrappedCollection<StaticClassPropertyWithCodeAnalysis, StaticPartialClassPropertyWithCodeAnalysis>(
                classType.Properties,
                parent => new StaticPartialClassPropertyWithCodeAnalysis(parent),
                child => child.Property,
                value => classType.Properties = value);
            structs = new StaticPartialClassNestedStructCollectionWithCodeAnalysis(classType.Structs);
            members = type.Members;
        }

        public StaticClassWithCodeAnalysis Class
        {
            get { return classType; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return classType.Attributes; }
            set { classType.Attributes = value; }
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
            get { return classType.GenericParameters; }
            set { classType.GenericParameters = value; }
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
            get { return classType.StaticConstructor; }
            set { classType.StaticConstructor = value; }
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
            get { return classType.Node.GetParentNode<NamespaceWithCodeAnalysis>(); }
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
            get { return classType.Syntax; }
            set { classType.Syntax = value; }
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
            get { return classType.Node; }
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
