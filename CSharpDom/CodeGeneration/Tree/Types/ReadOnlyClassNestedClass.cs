using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System;
using System.Collections.Generic;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyClassNestedClass :
        AbstractClassNestedClass<
            AttributeGroupNotSupported,
            IType,
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
            NestedDestructorNotSupported,
            ReadOnlyStaticConstructor,
            ReadOnlyExplicitInterfaceEvent,
            ReadOnlyExplicitInterfaceProperty,
            ReadOnlyExplicitInterfaceIndexer,
            ReadOnlyExplicitInterfaceMethod>
    {
        private readonly ClassNestedClass nestedClass;
        private readonly IReadOnlyList<ReadOnlyGenericParameterDeclaration> genericParameters;
        private readonly ReadOnlyClassReference baseClass;
        private readonly IReadOnlyCollection<ReadOnlyInterfaceReference> implementedInterfaces;
        private readonly ReadOnlyClassBody body;

        public ReadOnlyClassNestedClass(ClassNestedClass nestedClass)
        {
            this.nestedClass = nestedClass;
            genericParameters = ReadOnlyGenericParameterDeclaration.Create(nestedClass.GenericParameters);
            if (nestedClass.BaseClass != null)
            {
                baseClass = new ReadOnlyClassReference(nestedClass.BaseClass);
            }

            implementedInterfaces = ReadOnlyInterfaceReference.Create(nestedClass.Interfaces);
            body = new ReadOnlyClassBody(nestedClass.Body);
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

        public override IType DeclaringType
        {
            get { return null; }
        }

        public override IReadOnlyCollection<ReadOnlyClassNestedDelegate> Delegates
        {
            get { return body.Delegates; }
        }

        public override NestedDestructorNotSupported Destructor
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
                switch (nestedClass.InheritanceModifier)
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

        public override bool IsPartial
        {
            get { return nestedClass.IsPartial; }
        }

        public override IReadOnlyCollection<ReadOnlyClassMethod> Methods
        {
            get { return body.Methods; }
        }

        public override string Name
        {
            get { return nestedClass.Name; }
        }

        public override IReadOnlyCollection<ReadOnlyOperatorOverload> OperatorOverloads
        {
            get { return body.OperatorOverloads; }
        }

        public override IReadOnlyCollection<ReadOnlyClassProperty> Properties
        {
            get { return body.Properties; }
        }

        public override IReadOnlyCollection<ReadOnlyClassNestedStruct> Structs
        {
            get { return body.Structs; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return ReadOnlyClass.GetVisibility(nestedClass.Visibility); }
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
    }
}
