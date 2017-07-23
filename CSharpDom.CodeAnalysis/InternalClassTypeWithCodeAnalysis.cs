using System.Linq;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using System.Collections.Generic;
using System;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalClassTypeWithCodeAnalysis<TClass> : ClassTypeWithCodeAnalysis
        where TClass : class, IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly Node<TClass, ClassDeclarationSyntax> node;
        private readonly BaseTypeListWrapper<TClass, ClassDeclarationSyntax> baseTypes;
        private readonly AttributeListWrapper<TClass, ClassDeclarationSyntax> attributes;
        private readonly WrappedList<InterfaceReferenceWithCodeAnalysis, ClassReferenceWithCodeAnalysis> baseClass;
        private readonly InternalClassNestedClassCollectionWithCodeAnalysis<TClass> classes;
        private readonly ClassMemberListWrapper<TClass, ClassConstructorWithCodeAnalysis, ConstructorDeclarationSyntax> constructors;
        private readonly ClassMemberListWrapper<TClass, ClassConversionOperatorWithCodeAnalysis, ConversionOperatorDeclarationSyntax> conversionOperators;
        private readonly ClassMemberListWrapper<TClass, ClassNestedDelegateWithCodeAnalysis, DelegateDeclarationSyntax> delegates;
        private readonly ClassMemberListWrapper<TClass, ClassDestructorWithCodeAnalysis, DestructorDeclarationSyntax> destructor;
        private readonly ClassMemberListWrapper<TClass, ClassNestedEnumWithCodeAnalysis, EnumDeclarationSyntax> enums;
        private readonly InternalClassEventCollectionWithCodeAnalysis<TClass> events;
        private readonly InternalClassFieldCollectionWithCodeAnalysis<TClass> fields;
        private readonly GenericParameterDeclarationListWrapper<TClass, ClassDeclarationSyntax> genericParameters;
        private readonly FilteredList<InterfaceReferenceWithCodeAnalysis> implementedInterfaces;
        private readonly InternalClassIndexerCollectionWithCodeAnalysis<TClass> indexers;
        private readonly ClassMemberListWrapper<TClass, ClassNestedInterfaceWithCodeAnalysis, InterfaceDeclarationSyntax> interfaces;
        private readonly InternalClassMethodCollectionWithCodeAnalysis<TClass> methods;
        private readonly ClassMemberListWrapper<TClass, ClassOperatorOverloadWithCodeAnalysis, OperatorDeclarationSyntax> operatorOverloads;
        private readonly InternalClassPropertyCollectionWithCodeAnalysis<TClass> properties;
        private readonly ClassMemberListWrapper<TClass, ClassStaticConstructorWithCodeAnalysis, ConstructorDeclarationSyntax> staticConstructor;
        private readonly InternalClassNestedStructCollectionWithCodeAnalysis<TClass> structs;
        private readonly IMemberList members;

        internal InternalClassTypeWithCodeAnalysis(TClass @class)
        {
            node = new Node<TClass, ClassDeclarationSyntax>(@class);
            baseTypes = new BaseTypeListWrapper<TClass, ClassDeclarationSyntax>(
                node,
                (parentSyntax, childSyntax) => parentSyntax.WithBaseList(childSyntax));
            attributes = new AttributeListWrapper<TClass, ClassDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax));
            baseClass = new WrappedList<InterfaceReferenceWithCodeAnalysis, ClassReferenceWithCodeAnalysis>(
                baseTypes,
                @interface => new ClassReferenceWithCodeAnalysis(@interface.TypeReference),
                newClass => new InterfaceReferenceWithCodeAnalysis(newClass.TypeReference),
                classToFilter => false);
            classes = new InternalClassNestedClassCollectionWithCodeAnalysis<TClass>(this);
            constructors = new ClassMemberListWrapper<TClass, ClassConstructorWithCodeAnalysis, ConstructorDeclarationSyntax>(
                node,
                () => new ClassConstructorWithCodeAnalysis(),
                syntax => !syntax.IsStatic());
            conversionOperators = new ClassMemberListWrapper<TClass, ClassConversionOperatorWithCodeAnalysis, ConversionOperatorDeclarationSyntax>(
                node,
                () => new ClassConversionOperatorWithCodeAnalysis());
            destructor = new ClassMemberListWrapper<TClass, ClassDestructorWithCodeAnalysis, DestructorDeclarationSyntax>(
                node,
                () => new ClassDestructorWithCodeAnalysis());
            delegates = new ClassMemberListWrapper<TClass, ClassNestedDelegateWithCodeAnalysis, DelegateDeclarationSyntax>(
                node,
                () => new ClassNestedDelegateWithCodeAnalysis());
            enums = new ClassMemberListWrapper<TClass, ClassNestedEnumWithCodeAnalysis, EnumDeclarationSyntax>(
                node,
                () => new ClassNestedEnumWithCodeAnalysis());
            events = new InternalClassEventCollectionWithCodeAnalysis<TClass>(this);
            fields = new InternalClassFieldCollectionWithCodeAnalysis<TClass>(this);
            genericParameters = new GenericParameterDeclarationListWrapper<TClass, ClassDeclarationSyntax>(
                node,
                syntax => syntax.TypeParameterList,
                (parentSyntax, childSyntax) => parentSyntax.WithTypeParameterList(childSyntax),
                syntax => syntax.ConstraintClauses,
                (parentSyntax, childSyntax) => parentSyntax.WithConstraintClauses(childSyntax));
            implementedInterfaces = new FilteredList<InterfaceReferenceWithCodeAnalysis>(baseTypes);
            indexers = new InternalClassIndexerCollectionWithCodeAnalysis<TClass>(this);
            interfaces = new ClassMemberListWrapper<TClass, ClassNestedInterfaceWithCodeAnalysis, InterfaceDeclarationSyntax>(
                node,
                () => new ClassNestedInterfaceWithCodeAnalysis());
            methods = new InternalClassMethodCollectionWithCodeAnalysis<TClass>(this);
            operatorOverloads = new ClassMemberListWrapper<TClass, ClassOperatorOverloadWithCodeAnalysis, OperatorDeclarationSyntax>(
                node,
                () => new ClassOperatorOverloadWithCodeAnalysis());
            properties = new InternalClassPropertyCollectionWithCodeAnalysis<TClass>(this);
            staticConstructor = new ClassMemberListWrapper<TClass, ClassStaticConstructorWithCodeAnalysis, ConstructorDeclarationSyntax>(
                node,
                () => new ClassStaticConstructorWithCodeAnalysis(),
                syntax => syntax.IsStatic());
            structs = new InternalClassNestedStructCollectionWithCodeAnalysis<TClass>(this);
            members = new ClassMemberList<TClass>(node, (parentSyntax, childSyntax) => parentSyntax.WithMembers(childSyntax))
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
                { nameof(classes.Classes), () => classes.Classes.Select(item => item.Syntax) },
                { nameof(classes.AbstractClasses), () => classes.AbstractClasses.Select(item => item.Syntax) },
                { nameof(classes.SealedClasses), () => classes.SealedClasses.Select(item => item.Syntax) },
                { nameof(classes.StaticClasses), () => classes.StaticClasses.Select(item => item.Syntax) },
                { nameof(Interfaces), () => interfaces.Select(item => item.Syntax) }
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

        public override ICollection<ClassConversionOperatorWithCodeAnalysis> ConversionOperators
        {
            get { return conversionOperators; }
            set { members.CombineList(nameof(ConversionOperators), value.Select(item => item.Syntax)); }
        }

        public override ICollection<ClassNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return delegates; }
            set { members.CombineList(nameof(Delegates), value.Select(item => item.Syntax)); }
        }

        public override ClassDestructorWithCodeAnalysis Destructor
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

        public override ICollection<ClassNestedInterfaceWithCodeAnalysis> Interfaces
        {
            get { return interfaces; }
            set { members.CombineList(nameof(Interfaces), interfaces.Select(item => item.Syntax)); }
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

        public override ICollection<ClassOperatorOverloadWithCodeAnalysis> OperatorOverloads
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

        public override ClassStaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return staticConstructor.GetStaticConstructor(); }
            set { staticConstructor.SetStaticConstructor(value); }
        }

        public override ClassNestedStructCollectionWithCodeAnalysis Structs
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

        internal IMemberList Members
        {
            get { return members; }
        }
    }
}
