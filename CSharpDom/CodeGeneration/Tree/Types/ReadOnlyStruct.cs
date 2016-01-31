using CSharpDom.BaseClasses;
using CSharpDom.NotSupported;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyStruct :
        AbstractStruct<
            NamespaceNotSupported,
            ProjectNotSupported,
            SolutionNotSupported,
            AttributeGroupNotSupported,
            ReadOnlyGenericParameterDeclaration,
            ReadOnlyInterfaceReference,
            ReadOnlyStructEvent,
            ReadOnlyStructProperty,
            ReadOnlyStructIndexer,
            ReadOnlyStructMethod,
            ReadOnlyStructFieldDeclaration,
            ConstructorNotSupported,
            ReadOnlyStructEvent,
            ReadOnlyOperatorOverload,
            ReadOnlyConversionOperator,
            ReadOnlyStructNestedClass,
            ReadOnlyStructNestedDelegate,
            ReadOnlyStructNestedEnum,
            ReadOnlyStructNestedInterface,
            ReadOnlyStructNestedStruct>
    {
        private readonly Struct @struct;
        private readonly IReadOnlyList<ReadOnlyGenericParameterDeclaration> genericParameters;
        private readonly IReadOnlyCollection<ReadOnlyInterfaceReference> implementedInterfaces;
        private readonly ReadOnlyStructBody body;

        public ReadOnlyStruct(Struct @struct)
        {
            this.@struct = @struct;
            genericParameters = ReadOnlyGenericParameterDeclaration.Create(@struct.GenericParameters);
            implementedInterfaces = ReadOnlyInterfaceReference.Create(@struct.Interfaces);
            body = new ReadOnlyStructBody(@struct.Body);
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override IReadOnlyCollection<ReadOnlyStructNestedClass> Classes
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

        public override IReadOnlyCollection<ReadOnlyStructNestedDelegate> Delegates
        {
            get { return body.Delegates; }
        }

        public override IReadOnlyCollection<ReadOnlyStructNestedEnum> Enums
        {
            get { return body.Enums; }
        }

        public override IReadOnlyCollection<ReadOnlyStructEvent> EventProperties
        {
            get { return body.EventProperties; }
        }

        public override IReadOnlyCollection<ReadOnlyStructEvent> Events
        {
            get { return body.Events; }
        }

        public override IReadOnlyCollection<ReadOnlyStructFieldDeclaration> Fields
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

        public override IReadOnlyCollection<ReadOnlyStructIndexer> Indexers
        {
            get { return body.Indexers; }
        }

        public override IReadOnlyCollection<ReadOnlyStructNestedInterface> Interfaces
        {
            get { return body.Interfaces; }
        }

        public override bool IsPartial
        {
            get { return @struct.IsPartial; }
        }

        public override IReadOnlyCollection<ReadOnlyStructMethod> Methods
        {
            get { return body.Methods; }
        }

        public override string Name
        {
            get { return @struct.Name; }
        }

        public override NamespaceNotSupported Namespace
        {
            get { return new NamespaceNotSupported(); }
        }

        public override IReadOnlyCollection<ReadOnlyOperatorOverload> OperatorOverloads
        {
            get { return body.OperatorOverloads; }
        }

        public override IReadOnlyCollection<ReadOnlyStructProperty> Properties
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

        public override IReadOnlyCollection<ReadOnlyStructNestedStruct> Structs
        {
            get { return body.Structs; }
        }

        public override TypeVisibilityModifier Visibility
        {
            get { return @struct.Visibility; }
        }

        public static MemberVisibilityModifier GetVisibility(StructMemberVisibilityModifier visibility)
        {
            switch (visibility)
            {
                case StructMemberVisibilityModifier.None:
                    return MemberVisibilityModifier.None;
                case StructMemberVisibilityModifier.Public:
                    return MemberVisibilityModifier.Public;
                case StructMemberVisibilityModifier.Internal:
                    return MemberVisibilityModifier.Internal;
                case StructMemberVisibilityModifier.Private:
                    return MemberVisibilityModifier.Private;
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
