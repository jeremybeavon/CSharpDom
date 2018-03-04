using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis.Partial
{
    internal sealed class InternalNestedStaticPartialClassWithCodeAnalysis<TClass> :
        NestedStaticPartialClassWithCodeAnalysis
        where TClass : class, IHasNode<ClassDeclarationSyntax>
    {
        private readonly InternalNestedStaticClassWithCodeAnalysis<TClass> classType;
        private readonly IMemberList members;
        private readonly NestedStaticPartialClassNestedClassCollectionWithCodeAnalysis classes;
        private readonly WrappedCollection<
            NestedStaticClassNestedDelegateWithCodeAnalysis,
            NestedStaticPartialClassNestedDelegateWithCodeAnalysis> delegates;
        private readonly WrappedCollection<
            NestedStaticClassNestedEnumWithCodeAnalysis,
            NestedStaticPartialClassNestedEnumWithCodeAnalysis> enums;
        private readonly NestedStaticPartialClassEventCollectionWithCodeAnalysis events;
        private readonly NestedStaticPartialClassFieldCollectionWithCodeAnalysis fields;
        private readonly WrappedCollection<
            NestedStaticClassNestedInterfaceWithCodeAnalysis,
            NestedStaticPartialClassNestedInterfaceWithCodeAnalysis> interfaces;
        private readonly NestedStaticPartialClassMethodCollectionWithCodeAnalysis methods;
        private readonly NestedStaticPartialClassPropertyCollectionWithCodeAnalysis properties;
        private readonly NestedStaticPartialClassNestedStructCollectionWithCodeAnalysis structs;

        internal InternalNestedStaticPartialClassWithCodeAnalysis(InternalNestedStaticClassWithCodeAnalysis<TClass> classType)
        {
            this.classType = classType;
            members = classType.Members;
            classes = new NestedStaticPartialClassNestedClassCollectionWithCodeAnalysis(classType.Classes);
            delegates = new WrappedCollection<NestedStaticClassNestedDelegateWithCodeAnalysis, NestedStaticPartialClassNestedDelegateWithCodeAnalysis>(
                classType.Delegates,
                parent => new NestedStaticPartialClassNestedDelegateWithCodeAnalysis(parent),
                child => child.InternalDelegate,
                value => classType.Delegates = value);
            enums = new WrappedCollection<NestedStaticClassNestedEnumWithCodeAnalysis, NestedStaticPartialClassNestedEnumWithCodeAnalysis>(
                classType.Enums,
                parent => new NestedStaticPartialClassNestedEnumWithCodeAnalysis(parent),
                child => child.InternalEnum,
                value => classType.Enums = value);
            events = new NestedStaticPartialClassEventCollectionWithCodeAnalysis(classType.Events);
            fields = new NestedStaticPartialClassFieldCollectionWithCodeAnalysis(classType.Fields);
            interfaces = new WrappedCollection<NestedStaticClassNestedInterfaceWithCodeAnalysis, NestedStaticPartialClassNestedInterfaceWithCodeAnalysis>(
                classType.Interfaces,
                parent => new NestedStaticPartialClassNestedInterfaceWithCodeAnalysis(parent),
                child => child.Interface,
                value => classType.Interfaces = value);
            methods = new InternalNestedStaticPartialClassMethodCollectionWithCodeAnalysis<TClass>(this);
            properties = new NestedStaticPartialClassPropertyCollectionWithCodeAnalysis(classType.Properties);
            structs = new NestedStaticPartialClassNestedStructCollectionWithCodeAnalysis(classType.Structs);
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return classType.Attributes; }
            set { classType.Attributes = value; }
        }

        public override NestedStaticPartialClassNestedClassCollectionWithCodeAnalysis Classes
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

        public override ICollection<NestedStaticPartialClassNestedEnumWithCodeAnalysis> Enums
        {
            get { return enums; }
            set { members.CombineList(nameof(Enums), value.Select(item => item.Syntax)); }
        }

        public override ICollection<NestedStaticPartialClassNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return delegates; }
            set { members.CombineList(nameof(Delegates), value.Select(item => item.Syntax)); }
        }

        public override NestedStaticPartialClassEventCollectionWithCodeAnalysis Events
        {
            get { return events; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(events.Events), value.Events.Select(item => item.Syntax)),
                    new MemberListSyntax(nameof(events.EventProperties), value.EventProperties.Select(item => item.Syntax)));
            }
        }

        public override NestedStaticPartialClassFieldCollectionWithCodeAnalysis Fields
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

        public override ICollection<NestedStaticPartialClassNestedInterfaceWithCodeAnalysis> Interfaces
        {
            get { return interfaces; }
            set { members.CombineList(nameof(Interfaces), value.Select(item => item.Syntax)); }
        }

        public override NestedStaticPartialClassMethodCollectionWithCodeAnalysis Methods
        {
            get { return methods; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(methods.Methods), value.Methods.Select(item => item.Syntax)),
                    new MemberListSyntax(nameof(methods.PartialMethodDefinitions), value.PartialMethodDefinitions.Select(item => item.Syntax)),
                    new MemberListSyntax(nameof(methods.PartialMethodImplementations), value.PartialMethodImplementations.Select(item => item.Syntax)));
            }
        }

        public override string Name
        {
            get { return classType.Name; }
            set { classType.Name = value; }
        }

        public override NestedStaticPartialClassPropertyCollectionWithCodeAnalysis Properties
        {
            get { return properties; }
            set { members.CombineList(nameof(Properties), value.Select(item => item.Syntax)); }
        }

        public override StaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return classType.StaticConstructor; }
            set { classType.StaticConstructor = value; }
        }

        public override NestedStaticPartialClassNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return structs; }
            set { members.CombineList(nameof(structs.Structs), value.Structs.Select(item => item.Syntax)); }
        }

        public override ClassDeclarationSyntax Syntax
        {
            get { return classType.Syntax; }
            set { classType.Syntax = value; }
        }

        public override IType DeclaringType
        {
            get { return InternalNode.GetParent<IType>(); }
            set { throw new NotSupportedException(); }
        }

        internal Node<TClass, ClassDeclarationSyntax> InternalNode => classType.InternalNode;

        internal IMemberList Members => classType.Members;
    }
}
