using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyStructNestedDelegate :
        AbstractStructNestedDelegate<
            AttributeGroupNotSupported,
            IStructType,
            ReadOnlyGenericParameterDeclaration,
            ReadOnlyTypeReference,
            ReadOnlyDelegateParameter>
    {
        private readonly StructNestedDelegate nestedDelegate;
        private readonly IReadOnlyList<ReadOnlyGenericParameterDeclaration> genericParameters;
        private readonly IReadOnlyList<ReadOnlyDelegateParameter> parameters;
        private readonly ReadOnlyTypeReference returnType;

        public ReadOnlyStructNestedDelegate(StructNestedDelegate nestedDelegate)
        {
            this.nestedDelegate = nestedDelegate;
            genericParameters = ReadOnlyGenericParameterDeclaration.Create(nestedDelegate.GenericParameters);
            parameters = ReadOnlyDelegateParameter.Create(nestedDelegate.Parameters);
            returnType = new ReadOnlyTypeReference(nestedDelegate.ReturnType);
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override IStructType DeclaringType
        {
            get { return null; }
        }

        public override IReadOnlyList<ReadOnlyGenericParameterDeclaration> GenericParameters
        {
            get { return genericParameters; }
        }

        public override string Name
        {
            get { return nestedDelegate.Name; }
        }

        public override IReadOnlyList<ReadOnlyDelegateParameter> Parameters
        {
            get { return parameters; }
        }

        public override ReadOnlyTypeReference ReturnType
        {
            get { return returnType; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get { return nestedDelegate.Visibility; }
        }
    }
}
