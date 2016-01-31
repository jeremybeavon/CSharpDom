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
            DestructorNotSupported>
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

        public static MemberInheritanceModifier GetInheritanceModifier(ClassMemberInheritanceModifier inheritanceModifier)
        {
            switch (inheritanceModifier)
            {
                case ClassMemberInheritanceModifier.None:
                    return MemberInheritanceModifier.None;
                case ClassMemberInheritanceModifier.Abstract:
                    return MemberInheritanceModifier.Abstract;
                case ClassMemberInheritanceModifier.New:
                    return MemberInheritanceModifier.New;
                case ClassMemberInheritanceModifier.NewStatic:
                    return MemberInheritanceModifier.NewStatic;
                case ClassMemberInheritanceModifier.NewVirtual:
                    return MemberInheritanceModifier.NewVirtual;
                case ClassMemberInheritanceModifier.Override:
                    return MemberInheritanceModifier.Override;
                case ClassMemberInheritanceModifier.SealedOverride:
                    return MemberInheritanceModifier.SealedOverride;
                case ClassMemberInheritanceModifier.Static:
                    return MemberInheritanceModifier.Static;
                case ClassMemberInheritanceModifier.Virtual:
                    return MemberInheritanceModifier.Virtual;
                default:
                    throw new NotSupportedException();
            }
        }

        public static MemberVisibilityModifier GetVisibility(ClassMemberVisibilityModifier visibility)
        {
            switch (visibility)
            {
                case ClassMemberVisibilityModifier.None:
                    return MemberVisibilityModifier.None;
                case ClassMemberVisibilityModifier.Public:
                    return MemberVisibilityModifier.Public;
                case ClassMemberVisibilityModifier.Internal:
                    return MemberVisibilityModifier.Internal;
                case ClassMemberVisibilityModifier.ProtectedInternal:
                    return MemberVisibilityModifier.ProtectedInternal;
                case ClassMemberVisibilityModifier.Protected:
                    return MemberVisibilityModifier.Protected;
                case ClassMemberVisibilityModifier.Private:
                    return MemberVisibilityModifier.Private;
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
