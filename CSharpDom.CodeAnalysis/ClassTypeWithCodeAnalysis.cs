using System.Linq;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using System.Collections.Generic;
using System;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassTypeWithCodeAnalysis :
        EditableClassType<
            AttributeGroupWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ClassReferenceWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            ClassEventCollectionWithCodeAnalysis,
            ClassPropertyCollectionWithCodeAnalysis,
            ClassIndexerCollectionWithCodeAnalysis,
            ClassMethodCollectionWithCodeAnalysis,
            ClassFieldCollectionWithCodeAnalysis,
            ClassConstructorWithCodeAnalysis,
            OperatorOverloadWithCodeAnalysis,
            ConversionOperatorWithCodeAnalysis,
            ClassNestedClassCollectionWithCodeAnalysis,
            ClassNestedDelegateWithCodeAnalysis,
            ClassNestedEnumWithCodeAnalysis,
            ClassNestedInterfaceCollectionWithCodeAnalysis,
            ClassNestedStructCollectionWithCodeAnalysis,
            DestructorWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>,
        IHasSyntax<ClassDeclarationSyntax>,
        ISimpleMember
    {
        private readonly object @class;
        private readonly Node<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax> node;
        private readonly BaseTypeListWrapper<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax> baseTypes;
        private readonly AttributeListWrapper<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax> attributes;
        private readonly WrappedList<InterfaceReferenceWithCodeAnalysis, ClassReferenceWithCodeAnalysis> baseClass;
        private readonly ClassNestedClassCollectionWithCodeAnalysis classes;
        private readonly ClassMemberListWrapper<
            ConstructorWithCodeAnalysis,
            ClassConstructorWithCodeAnalysis,
            ConstructorDeclarationSyntax> constructors;
        private readonly SimpleClassMemberListWrapper<
            ConversionOperatorWithCodeAnalysis,
            ConversionOperatorDeclarationSyntax> conversionOperators;
        private readonly ClassMemberListWrapper<
            DelegateTypeWithCodeAnalysis,
            ClassNestedDelegateWithCodeAnalysis,
            DelegateDeclarationSyntax> delegates;
        private readonly SimpleClassMemberListWrapper<DestructorWithCodeAnalysis, DestructorDeclarationSyntax> destructor;
        private readonly ClassMemberListWrapper<
            NestedEnumWithCodeAnalysis,
            ClassNestedEnumWithCodeAnalysis,
            EnumDeclarationSyntax> enums;
        private readonly ClassEventCollectionWithCodeAnalysis events;
        private readonly ClassFieldCollectionWithCodeAnalysis fields;
        private readonly GenericParameterDeclarationListWrapper<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax> genericParameters;
        private readonly FilteredList<InterfaceReferenceWithCodeAnalysis> implementedInterfaces;
        private readonly ClassIndexerCollectionWithCodeAnalysis indexers;
        private readonly ClassNestedInterfaceCollectionWithCodeAnalysis interfaces;
        private readonly ClassMethodCollectionWithCodeAnalysis methods;
        private readonly SimpleClassMemberListWrapper<
            OperatorOverloadWithCodeAnalysis,
            OperatorDeclarationSyntax> operatorOverloads;
        private readonly ClassPropertyCollectionWithCodeAnalysis properties;
        private readonly SimpleClassMemberListWrapper<StaticConstructorWithCodeAnalysis, ConstructorDeclarationSyntax> staticConstructor;
        private readonly ClassNestedStructCollectionWithCodeAnalysis structs;
        private readonly ClassMemberList members;

        internal ClassTypeWithCodeAnalysis(ClassTypeWithCodeAnalysis parent, ClassNestedClassWithCodeAnalysis @class)
            : this(@class)
        {
            SetClassParent(parent, ClassType.Normal);
        }

        internal ClassTypeWithCodeAnalysis(ClassTypeWithCodeAnalysis parent, ClassNestedAbstractClassWithCodeAnalysis @class)
            : this(@class)
        {
            SetClassParent(parent, ClassType.Abstract);
        }

        internal ClassTypeWithCodeAnalysis(ClassTypeWithCodeAnalysis parent, ClassNestedSealedClassWithCodeAnalysis @class)
            : this(@class)
        {
            SetClassParent(parent, ClassType.Sealed);
        }

        internal ClassTypeWithCodeAnalysis(StaticTypeWithCodeAnalysis parent, StaticClassNestedClassWithCodeAnalysis @class)
            : this(@class)
        {
            SetStaticClassParent(parent, ClassType.Normal);
        }

        internal ClassTypeWithCodeAnalysis(StaticTypeWithCodeAnalysis parent, StaticClassNestedAbstractClassWithCodeAnalysis @class)
            : this(@class)
        {
            SetStaticClassParent(parent, ClassType.Abstract);
        }

        internal ClassTypeWithCodeAnalysis(StaticTypeWithCodeAnalysis parent, StaticClassNestedSealedClassWithCodeAnalysis @class)
            : this(@class)
        {
            SetStaticClassParent(parent, ClassType.Sealed);
        }

        internal ClassTypeWithCodeAnalysis(StructTypeWithCodeAnalysis parent, StructNestedClassWithCodeAnalysis @class)
            : this(@class)
        {
            SetStructParent(parent, ClassType.Normal);
        }

        internal ClassTypeWithCodeAnalysis(StructTypeWithCodeAnalysis parent, StructNestedAbstractClassWithCodeAnalysis @class)
            : this(@class)
        {
            SetStructParent(parent, ClassType.Abstract);
        }

        internal ClassTypeWithCodeAnalysis(StructTypeWithCodeAnalysis parent, StructNestedSealedClassWithCodeAnalysis @class)
            : this(@class)
        {
            SetStructParent(parent, ClassType.Sealed);
        }

        private ClassTypeWithCodeAnalysis(object @class)
        {
            node = new Node<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(this);
            this.@class = @class;
            baseTypes = new BaseTypeListWrapper<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                node,
                (parentSyntax, childSyntax) => parentSyntax.WithBaseList(childSyntax),
                null,
                null);
            attributes = new AttributeListWrapper<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax),
                parent => new AttributeGroupWithCodeAnalysis(parent),
                (child, parent) => child.ClassParent = parent);
            baseClass = new WrappedList<InterfaceReferenceWithCodeAnalysis, ClassReferenceWithCodeAnalysis>(
                baseTypes,
                @interface => new ClassReferenceWithCodeAnalysis(@interface.TypeReference),
                newClass => new InterfaceReferenceWithCodeAnalysis(newClass.TypeReference),
                classToFilter => false);
            classes = new ClassNestedClassCollectionWithCodeAnalysis(this);
            constructors = new ClassMemberListWrapper<ConstructorWithCodeAnalysis, ClassConstructorWithCodeAnalysis, ConstructorDeclarationSyntax>(
                node,
                parent => new ClassConstructorWithCodeAnalysis(parent),
                (child, parent) => child.Constructor.ClassParent = parent,
                syntax => !syntax.IsStatic());
            conversionOperators = new SimpleClassMemberListWrapper<ConversionOperatorWithCodeAnalysis, ConversionOperatorDeclarationSyntax>(
                node,
                parent => new ConversionOperatorWithCodeAnalysis(parent),
                (child, parent) => child.ClassParent = parent);
            destructor = new SimpleClassMemberListWrapper<DestructorWithCodeAnalysis, DestructorDeclarationSyntax>(
                node,
                parent => new DestructorWithCodeAnalysis(parent),
                (child, parent) => child.ClassParent = parent);
            delegates = new ClassMemberListWrapper<DelegateTypeWithCodeAnalysis, ClassNestedDelegateWithCodeAnalysis, DelegateDeclarationSyntax>(
                node,
                parent => new ClassNestedDelegateWithCodeAnalysis(parent),
                (child, parent) => child.Delegate.Delegate.ClassParent = parent);
            enums = new ClassMemberListWrapper<NestedEnumWithCodeAnalysis, ClassNestedEnumWithCodeAnalysis, EnumDeclarationSyntax>(
                node,
                parent => new ClassNestedEnumWithCodeAnalysis(parent),
                (child, parent) => child.Enum.ClassParent = parent);
            events = new ClassEventCollectionWithCodeAnalysis(this);
            fields = new ClassFieldCollectionWithCodeAnalysis(this);
            genericParameters = new GenericParameterDeclarationListWrapper<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                node,
                syntax => syntax.TypeParameterList,
                (parentSyntax, childSyntax) => parentSyntax.WithTypeParameterList(childSyntax),
                syntax => syntax.ConstraintClauses,
                (parentSyntax, childSyntax) => parentSyntax.WithConstraintClauses(childSyntax),
                parent => new GenericParameterDeclarationWithCodeAnalysis(parent),
                (child, parent) => child.ClassParent = parent);
            implementedInterfaces = new FilteredList<InterfaceReferenceWithCodeAnalysis>(baseTypes);
            indexers = new ClassIndexerCollectionWithCodeAnalysis(this);
            interfaces = new ClassNestedInterfaceCollectionWithCodeAnalysis(this);
            methods = new ClassMethodCollectionWithCodeAnalysis(this);
            operatorOverloads = new SimpleClassMemberListWrapper<OperatorOverloadWithCodeAnalysis, OperatorDeclarationSyntax>(
                node,
                parent => new OperatorOverloadWithCodeAnalysis(parent),
                (child, parent) => child.ClassParent = parent);
            properties = new ClassPropertyCollectionWithCodeAnalysis(this);
            staticConstructor = new SimpleClassMemberListWrapper<StaticConstructorWithCodeAnalysis, ConstructorDeclarationSyntax>(
                node,
                parent => new StaticConstructorWithCodeAnalysis(parent),
                (child, parent) => child.ClassParent = parent,
                syntax => syntax.IsStatic());
            structs = new ClassNestedStructCollectionWithCodeAnalysis(this);
            members = new ClassMemberList(node, (parentSyntax, childSyntax) => parentSyntax.WithMembers(childSyntax))
            {
                { nameof(fields.Constants), () => fields.Constants.Select(item => item.Syntax) },
                { nameof(fields.Fields), () => fields.Fields.Select(item => item.Syntax) },
                { nameof(Enums), () => enums.Select(item => item.Syntax) },
                { nameof(Delegates), () => delegates.Select(item => item.Syntax) },
                { nameof(events.Events), () => events.Events.Select(item => item.Syntax) },
                { nameof(events.EventProperties), () => events.EventProperties.Select(item => item.Syntax) },
                { nameof(events.ExplicitInterfaceEvents), () => events.ExplicitInterfaceEvents.Select(item => item.Syntax) },
                { nameof(StaticConstructor), () => staticConstructor.Select(item => item.Syntax) },
                { nameof(Constructors), () => constructors.Select(item => item.Syntax) },
                { nameof(properties.Properties), () => properties.Properties.Select(item => item.Syntax) },
                { nameof(properties.ExplicitInterfaceProperties), () => properties.ExplicitInterfaceProperties.Select(item => item.Syntax) },
                { nameof(indexers.Indexers), () => indexers.Indexers.Select(item => item.Syntax) },
                { nameof(indexers.ExplicitInterfaceIndexers), () => indexers.ExplicitInterfaceIndexers.Select(item => item.Syntax) },
                { nameof(methods.Methods), () => methods.Methods.Select(item => item.Syntax) },
                { nameof(methods.ExplicitInterfaceMethods), () => methods.ExplicitInterfaceMethods.Select(item => item.Syntax) },
                { nameof(OperatorOverloads), () => operatorOverloads.Select(item => item.Syntax) },
                { nameof(ConversionOperators), () => conversionOperators.Select(item => item.Syntax) },
                { nameof(interfaces.Interfaces), () => interfaces.Interfaces.Select(item => item.Syntax) }
            };
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { attributes.ReplaceList(value); }
        }

        public override ClassReferenceWithCodeAnalysis BaseClass
        {
            get { return baseClass.FirstOrDefault(); }
            set { baseClass.ReplaceFirst(value); }
        }

        public override ClassNestedClassCollectionWithCodeAnalysis Classes
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

        public override ICollection<ClassConstructorWithCodeAnalysis> Constructors
        {
            get { return constructors; }
            set { members.CombineList(nameof(Constructors), value.Select(item => item.Syntax)); }
        }

        public override ICollection<ConversionOperatorWithCodeAnalysis> ConversionOperators
        {
            get { return conversionOperators; }
            set { members.CombineList(nameof(ConversionOperators), value.Select(item => item.Syntax)); }
        }

        public override ICollection<ClassNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return delegates; }
            set { members.CombineList(nameof(Delegates), value.Select(item => item.Syntax)); }
        }

        public override DestructorWithCodeAnalysis Destructor
        {
            get { return destructor.FirstOrDefault(); }
            set { destructor.ReplaceFirst(value); }
        }

        public override ICollection<ClassNestedEnumWithCodeAnalysis> Enums
        {
            get { return enums; }
            set { members.CombineList(nameof(Enums), value.Select(item => item.Syntax)); }
        }

        public override ClassEventCollectionWithCodeAnalysis Events
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

        public override ClassFieldCollectionWithCodeAnalysis Fields
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
            set
            {
                baseTypes.ReplaceList(
                    baseClass.Select(@class => new InterfaceReferenceWithCodeAnalysis(@class.TypeReference)).Concat(value));
            }
        }

        public override ClassIndexerCollectionWithCodeAnalysis Indexers
        {
            get { return indexers; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(indexers.Indexers), value.Indexers.Select(item => item.Syntax)),
                    new MemberListSyntax(nameof(indexers.ExplicitInterfaceIndexers), value.ExplicitInterfaceIndexers.Select(item => item.Syntax)));
            }
        }

        public override ClassNestedInterfaceCollectionWithCodeAnalysis Interfaces
        {
            get { return interfaces; }
            set { members.CombineList(nameof(interfaces.Interfaces), value.Interfaces.Select(item => item.Syntax)); }
        }

        public override ClassMethodCollectionWithCodeAnalysis Methods
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

        public override ClassPropertyCollectionWithCodeAnalysis Properties
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

        public override ClassNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return structs; }
            set { members.CombineList(nameof(structs.Structs), value.Structs.Select(item => item.Syntax)); }
        }

        public ClassDeclarationSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        internal Node<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax> Node
        {
            get { return node; }
        }

        internal ClassMemberList Members
        {
            get { return members; }
        }

        internal AbstractTypeWithCodeAnalysis AbstractType { get; private set; }

        internal SealedTypeWithCodeAnalysis SealedType { get; private set; }

        internal IAttributeCollection AttributeList
        {
            get { return attributes; }
        }

        internal IChildCollection<ConstructorWithCodeAnalysis, ConstructorDeclarationSyntax> ConstructorList
        {
            get { return constructors; }
        }

        internal IChildCollection<ConversionOperatorWithCodeAnalysis, ConversionOperatorDeclarationSyntax> ConversionOperatorList
        {
            get { return conversionOperators; }
        }

        internal IChildCollection<DelegateTypeWithCodeAnalysis, DelegateDeclarationSyntax> DelegateList
        {
            get { return delegates; }
        }

        internal IChildCollection<DestructorWithCodeAnalysis, DestructorDeclarationSyntax> DestructorList
        {
            get { return destructor; }
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
        
        internal void SetClassParent(ClassTypeWithCodeAnalysis value, ClassType classType)
        {
            switch (classType)
            {
                case ClassType.Normal:
                    node.SetParentNode<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                        value,
                        parent => parent.Classes.ClassList);
                    break;
                case ClassType.Abstract:
                    node.SetParentNode<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                        value,
                        parent => parent.Classes.AbstractClassList);
                    break;
                case ClassType.Sealed:
                    node.SetParentNode<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                        value,
                        parent => parent.Classes.SealedClassList);
                    break;
            }
        }

        internal void SetStaticClassParent(StaticTypeWithCodeAnalysis value, ClassType classType)
        {
            //switch (classType)
            //{
            //    case ClassType.Normal:
            //        node.SetParentNode<StaticTypeWithCodeAnalysis, ClassDeclarationSyntax>(
            //            value,
            //            parent => parent.Classes.ClassList);
            //        break;
            //    case ClassType.Abstract:
            //        node.SetParentNode<StaticTypeWithCodeAnalysis, ClassDeclarationSyntax>(
            //            value,
            //            parent => parent.Classes.AbstractClassList);
            //        break;
            //    case ClassType.Sealed:
            //        node.SetParentNode<StaticTypeWithCodeAnalysis, ClassDeclarationSyntax>(
            //            value,
            //            parent => parent.Classes.SealedClassList);
            //        break;
            //}
        }

        internal void SetStructParent(StructTypeWithCodeAnalysis value, ClassType classType)
        {
            //switch (classType)
            //{
            //    case ClassType.Normal:
            //        node.SetParentNode<StructTypeWithCodeAnalysis, ClassDeclarationSyntax>(
            //            value,
            //            parent => parent.Classes.ClassList);
            //        break;
            //    case ClassType.Abstract:
            //        node.SetParentNode<StructTypeWithCodeAnalysis, ClassDeclarationSyntax>(
            //            value,
            //            parent => parent.Classes.AbstractClassList);
            //        break;
            //    case ClassType.Sealed:
            //        node.SetParentNode<StructTypeWithCodeAnalysis, ClassDeclarationSyntax>(
            //            value,
            //            parent => parent.Classes.SealedClassList);
            //        break;
            //}
        }

        T ISimpleMember.Member<T>()
        {
            return (T)@class;
        }
    }
}
