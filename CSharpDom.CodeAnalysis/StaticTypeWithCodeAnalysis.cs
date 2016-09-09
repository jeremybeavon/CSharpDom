using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticTypeWithCodeAnalysis :
        EditableStaticType<
            AttributeGroupWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            StaticClassEventCollectionWithCodeAnalysis,
            StaticClassPropertyWithCodeAnalysis,
            StaticClassMethodCollectionWithCodeAnalysis,
            StaticClassFieldCollectionWithCodeAnalysis,
            StaticClassNestedClassCollectionWithCodeAnalysis,
            StaticClassNestedDelegateWithCodeAnalysis,
            StaticClassNestedEnumWithCodeAnalysis,
            StaticClassNestedInterfaceCollectionWithCodeAnalysis,
            StaticClassNestedStructCollectionWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>,
        IHasSyntax<ClassDeclarationSyntax>,
        ISimpleMember
    {
        private readonly Node<StaticTypeWithCodeAnalysis, ClassDeclarationSyntax> node;
        private readonly object @class;
        private readonly AttributeListWrapper<StaticTypeWithCodeAnalysis, ClassDeclarationSyntax> attributes;
        private readonly StaticClassNestedClassCollectionWithCodeAnalysis classes;
        private readonly StaticTypeMemberListWrapper<
            DelegateTypeWithCodeAnalysis,
            StaticClassNestedDelegateWithCodeAnalysis,
            DelegateDeclarationSyntax> delegates;
        private readonly StaticTypeMemberListWrapper<
            NestedEnumWithCodeAnalysis,
            StaticClassNestedEnumWithCodeAnalysis,
            EnumDeclarationSyntax> enums;
        private readonly StaticClassEventCollectionWithCodeAnalysis events;
        private readonly StaticClassFieldCollectionWithCodeAnalysis fields;
        private readonly GenericParameterDeclarationListWrapper<StaticTypeWithCodeAnalysis, ClassDeclarationSyntax> genericParameters;
        private readonly StaticClassNestedInterfaceCollectionWithCodeAnalysis interfaces;
        private readonly StaticClassMethodCollectionWithCodeAnalysis methods;
        private readonly StaticTypeMemberListWrapper<
            PropertyWithCodeAnalysis,
            StaticClassPropertyWithCodeAnalysis,
            PropertyDeclarationSyntax> properties;
        private readonly StaticTypeMemberListWrapper<
            EmptySimpleMember,
            StaticConstructorWithCodeAnalysis,
            ConstructorDeclarationSyntax> staticConstructor;
        private readonly StaticClassNestedStructCollectionWithCodeAnalysis structs;
        private readonly MemberList<StaticTypeWithCodeAnalysis, ClassDeclarationSyntax> members;

        internal StaticTypeWithCodeAnalysis(ClassTypeWithCodeAnalysis parent, ClassNestedStaticClassWithCodeAnalysis @class)
            : this(@class)
        {

        }

        internal StaticTypeWithCodeAnalysis(StaticTypeWithCodeAnalysis parent, StaticClassNestedStaticClassWithCodeAnalysis @class)
            : this(@class)
        {

        }

        internal StaticTypeWithCodeAnalysis(StructTypeWithCodeAnalysis parent, StructNestedStaticClassWithCodeAnalysis @class)
            : this(@class)
        {

        }

        private StaticTypeWithCodeAnalysis(object @class)
        {
            node = new Node<StaticTypeWithCodeAnalysis, ClassDeclarationSyntax>(this);
            this.@class = @class;
            attributes = new AttributeListWrapper<StaticTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax),
                parent => new AttributeGroupWithCodeAnalysis(parent),
                (child, parent) => child.StaticClassParent = parent);
            classes = new StaticClassNestedClassCollectionWithCodeAnalysis(this);
            delegates = new StaticTypeMemberListWrapper<DelegateTypeWithCodeAnalysis, StaticClassNestedDelegateWithCodeAnalysis, DelegateDeclarationSyntax>(
                node,
                parent => new StaticClassNestedDelegateWithCodeAnalysis(parent),
                (child, parent) => child.Delegate.Delegate.StaticClassParent = parent);
            enums = new StaticTypeMemberListWrapper<NestedEnumWithCodeAnalysis, StaticClassNestedEnumWithCodeAnalysis, EnumDeclarationSyntax>(
                node,
                parent => new StaticClassNestedEnumWithCodeAnalysis(parent),
                (child, parent) => child.Enum.StaticClassParent = parent);
            events = new StaticClassEventCollectionWithCodeAnalysis(this);
            fields = new StaticClassFieldCollectionWithCodeAnalysis(this);
            genericParameters = new GenericParameterDeclarationListWrapper<StaticTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                node,
                syntax => syntax.TypeParameterList,
                (parentSyntax, childSyntax) => parentSyntax.WithTypeParameterList(childSyntax),
                syntax => syntax.ConstraintClauses,
                (parentSyntax, childSyntax) => parentSyntax.WithConstraintClauses(childSyntax),
                parent => new GenericParameterDeclarationWithCodeAnalysis(parent),
                (child, parent) => child.StaticClassParent = parent);
            interfaces = new StaticClassNestedInterfaceCollectionWithCodeAnalysis(this);
            methods = new StaticClassMethodCollectionWithCodeAnalysis(this);
            properties = new StaticTypeMemberListWrapper<PropertyWithCodeAnalysis, StaticClassPropertyWithCodeAnalysis, PropertyDeclarationSyntax>(
                node,
                parent => new StaticClassPropertyWithCodeAnalysis(parent),
                (child, parent) => child.Property.Property.StaticClassParent = parent);
            staticConstructor = new StaticTypeMemberListWrapper<EmptySimpleMember, StaticConstructorWithCodeAnalysis, ConstructorDeclarationSyntax>(
                node,
                parent => new StaticConstructorWithCodeAnalysis(parent),
                (child, parent) => child.StaticClassParent = parent);
            structs = new StaticClassNestedStructCollectionWithCodeAnalysis(this);
            members = new MemberList<StaticTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                node,
                (parentSyntax, childSyntax) => parentSyntax.WithMembers(childSyntax))
            {
                { nameof(fields.Constants), () => fields.Constants.Select(item => item.Syntax) },
                { nameof(fields.Fields), () => fields.Fields.Select(item => item.Syntax) },
                { nameof(Enums), () => enums.Select(item => item.Syntax) },
                { nameof(Delegates), () => delegates.Select(item => item.Syntax) },
                { nameof(events.Events), () => events.Events.Select(item => item.Syntax) },
                { nameof(events.EventProperties), () => events.EventProperties.Select(item => item.Syntax) },
                { nameof(interfaces.Interfaces), () => interfaces.Interfaces.Select(item => item.Syntax) },
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

        public override StaticClassNestedInterfaceCollectionWithCodeAnalysis Interfaces
        {
            get { return interfaces; }
            set { members.CombineList(nameof(interfaces.Interfaces), value.Interfaces.Select(item => item.Syntax)); }
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

        public ClassDeclarationSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        internal Node<StaticTypeWithCodeAnalysis, ClassDeclarationSyntax> Node
        {
            get { return node; }
        }

        internal MemberList<StaticTypeWithCodeAnalysis, ClassDeclarationSyntax> Members
        {
            get { return members; }
        }

        internal IAttributeCollection AttributeList
        {
            get { return attributes; }
        }

        internal IChildCollection<DelegateTypeWithCodeAnalysis, DelegateDeclarationSyntax> DelegateList
        {
            get { return delegates; }
        }

        internal IChildCollection<NestedEnumWithCodeAnalysis, EnumDeclarationSyntax> EnumList
        {
            get { return enums; }
        }

        internal IGenericParameterCollection GenericParameterList
        {
            get { return genericParameters; }
        }

        internal IChildCollection<PropertyWithCodeAnalysis, PropertyDeclarationSyntax> PropertyList
        {
            get { return properties; }
        }

        internal IChildCollection<StaticConstructorWithCodeAnalysis, ConstructorDeclarationSyntax> StaticConstructorList
        {
            get { return staticConstructor; }
        }

        T ISimpleMember.Member<T>()
        {
            return (T)@class;
        }
    }
}
