using CSharpDom.BaseClasses;
using CSharpDom.NotSupported;
using System;
using System.Collections.Generic;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyClass :
        AbstractClass<
            NamespaceNotSupported,
            ProjectNotSupported,
            SolutionNotSupported,
            AttributeGroupNotSupported,
            ReadOnlyGenericParameterDeclaration,
            ReadOnlyClassReference,
            ReadOnlyInterfaceReference,
            ReadOnlyClassEvent,
            ReadOnlyClassProperty,
            ReadOnlyClassIndexer,
            ReadOnlyClassMethod,
            ReadOnlyClassFieldDeclaration,
            ConstructorNotSupported,
            ReadOnlyClassEvent,
            ReadOnlyOperatorOverload,
            ReadOnlyConversionOperator,
            ReadOnlyClassNestedClass,
            ReadOnlyClassNestedDelegate,
            ReadOnlyClassNestedEnum,
            ReadOnlyClassNestedInterface,
            ReadOnlyClassNestedStruct,
            DestructorNotSupported,
            ReadOnlyStaticConstructor,
            ReadOnlyExplicitInterfaceEvent,
            ReadOnlyExplicitInterfaceProperty,
            ReadOnlyExplicitInterfaceIndexer,
            ReadOnlyExplicitInterfaceMethod>
    {
        private readonly Class @class;
        private readonly IReadOnlyList<ReadOnlyGenericParameterDeclaration> genericParameters;
        private readonly ReadOnlyClassReference baseClass;
        private readonly IReadOnlyCollection<ReadOnlyInterfaceReference> implementedInterfaces;
        private readonly ReadOnlyClassBody body;

        public ReadOnlyClass(Class @class)
        {
            this.@class = @class;
            genericParameters = ReadOnlyGenericParameterDeclaration.Create(@class.GenericParameters);
            if (@class.BaseClass != null)
            {
                baseClass = new ReadOnlyClassReference(@class.BaseClass);
            }

            implementedInterfaces = ReadOnlyInterfaceReference.Create(@class.Interfaces);
            body = new ReadOnlyClassBody(@class.Body);
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override ReadOnlyClassReference BaseClass
        {
            get { return baseClass; }
        }

        public override IReadOnlyCollection<ReadOnlyClassNestedClass> Classes
        {
            get { return body.Classes; }
        }

        public override IReadOnlyCollection<ConstructorNotSupported> Constructors
        {
            get { return body.Constructors; }
        }

        public override IReadOnlyCollection<ReadOnlyConversionOperator> ConversionOperators
        {
            get { return body.ConversionOperators; }
        }
        
        public override IReadOnlyCollection<ReadOnlyClassNestedDelegate> Delegates
        {
            get { return body.Delegates; }
        }

        public override DestructorNotSupported Destructor
        {
            get { return null; }
        }

        public override IReadOnlyCollection<ReadOnlyClassNestedEnum> Enums
        {
            get { return body.Enums; }
        }

        public override IReadOnlyCollection<ReadOnlyClassEvent> EventProperties
        {
            get { return body.EventProperties; }
        }

        public override IReadOnlyCollection<ReadOnlyClassEvent> Events
        {
            get { return body.Events; }
        }

        public override IReadOnlyCollection<ReadOnlyClassFieldDeclaration> Fields
        {
            get { return body.Fields; }
        }

        public override IReadOnlyList<ReadOnlyGenericParameterDeclaration> GenericParameters
        {
            get { return genericParameters; }
        }

        public override IReadOnlyCollection<ReadOnlyInterfaceReference> ImplementedInterfaces
        {
            get { return implementedInterfaces; }
        }

        public override IReadOnlyCollection<ReadOnlyClassIndexer> Indexers
        {
            get { return body.Indexers; }
        }

        public override TypeInheritanceModifier InheritanceModifier
        {
            get
            {
                switch (@class.InheritanceModifier)
                {
                    case TypeInheritanceModifier.Abstract:
                        return TypeInheritanceModifier.Abstract;
                    case TypeInheritanceModifier.None:
                        return TypeInheritanceModifier.None;
                    case TypeInheritanceModifier.Sealed:
                        return TypeInheritanceModifier.Sealed;
                    case TypeInheritanceModifier.Static:
                        return TypeInheritanceModifier.Static;
                    default:
                        throw new NotSupportedException();
                }
            }
        }

        public override IReadOnlyCollection<ReadOnlyClassNestedInterface> Interfaces
        {
            get { return body.Interfaces; }
        }

        public override IReadOnlyCollection<ReadOnlyClassMethod> Methods
        {
            get { return body.Methods; }
        }

        public override string Name
        {
            get { return @class.Name; }
        }

        public override NamespaceNotSupported Namespace
        {
            get { return new NamespaceNotSupported(); }
        }

        public override IReadOnlyCollection<ReadOnlyOperatorOverload> OperatorOverloads
        {
            get { return body.OperatorOverloads; }
        }

        public override IReadOnlyCollection<ReadOnlyClassProperty> Properties
        {
            get { return body.Properties; }
        }

        public override ProjectNotSupported Project
        {
            get { return new ProjectNotSupported(); }
        }

        public override SolutionNotSupported Solution
        {
            get { return new SolutionNotSupported(); }
        }

        public override IReadOnlyCollection<ReadOnlyClassNestedStruct> Structs
        {
            get { return body.Structs; }
        }

        public override TypeVisibilityModifier Visibility
        {
            get { return @class.Visibility; }
        }

        public override bool IsPartial
        {
            get { return @class.IsPartial; }
        }

        public override IReadOnlyCollection<ReadOnlyExplicitInterfaceEvent> ExplicitInterfaceEvents
        {
            get { return body.ExplicitInterfaceEvents; }
        }

        public override IReadOnlyCollection<ReadOnlyExplicitInterfaceIndexer> ExplicitInterfaceIndexers
        {
            get { return body.ExplicitInterfaceIndexers; }
        }

        public override IReadOnlyCollection<ReadOnlyExplicitInterfaceMethod> ExplicitInterfaceMethods
        {
            get { return body.ExplicitInterfaceMethods; }
        }

        public override IReadOnlyCollection<ReadOnlyExplicitInterfaceProperty> ExplicitInterfaceProperties
        {
            get { return body.ExplicitInterfaceProperties; }
        }

        public override ReadOnlyStaticConstructor StaticConstructor
        {
            get { return body.StaticConstructor; }
        }

        public static ClassMemberInheritanceModifier GetInheritanceModifier(ClassMemberInheritanceModifier inheritanceModifier)
        {
            switch (inheritanceModifier)
            {
                case ClassMemberInheritanceModifier.None:
                    return CSharpDom.ClassMemberInheritanceModifier.None;
                case ClassMemberInheritanceModifier.Abstract:
                    return CSharpDom.ClassMemberInheritanceModifier.Abstract;
                case ClassMemberInheritanceModifier.New:
                    return CSharpDom.ClassMemberInheritanceModifier.New;
                case ClassMemberInheritanceModifier.NewStatic:
                    return CSharpDom.ClassMemberInheritanceModifier.NewStatic;
                case ClassMemberInheritanceModifier.NewVirtual:
                    return CSharpDom.ClassMemberInheritanceModifier.NewVirtual;
                case ClassMemberInheritanceModifier.Override:
                    return CSharpDom.ClassMemberInheritanceModifier.Override;
                case ClassMemberInheritanceModifier.SealedOverride:
                    return CSharpDom.ClassMemberInheritanceModifier.SealedOverride;
                case ClassMemberInheritanceModifier.Static:
                    return CSharpDom.ClassMemberInheritanceModifier.Static;
                case ClassMemberInheritanceModifier.Virtual:
                    return CSharpDom.ClassMemberInheritanceModifier.Virtual;
                default:
                    throw new NotSupportedException();
            }
        }

        public static ClassMemberVisibilityModifier GetVisibility(ClassMemberVisibilityModifier visibility)
        {
            switch (visibility)
            {
                case ClassMemberVisibilityModifier.None:
                    return CSharpDom.ClassMemberVisibilityModifier.None;
                case ClassMemberVisibilityModifier.Public:
                    return CSharpDom.ClassMemberVisibilityModifier.Public;
                case ClassMemberVisibilityModifier.Internal:
                    return CSharpDom.ClassMemberVisibilityModifier.Internal;
                case ClassMemberVisibilityModifier.ProtectedInternal:
                    return CSharpDom.ClassMemberVisibilityModifier.ProtectedInternal;
                case ClassMemberVisibilityModifier.Protected:
                    return CSharpDom.ClassMemberVisibilityModifier.Protected;
                case ClassMemberVisibilityModifier.Private:
                    return CSharpDom.ClassMemberVisibilityModifier.Private;
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
