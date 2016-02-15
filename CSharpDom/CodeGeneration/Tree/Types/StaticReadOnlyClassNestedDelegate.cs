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
    public sealed class ReadOnlyStaticClassNestedDelegate :
        AbstractStaticClassNestedDelegate<
            AttributeGroupNotSupported,
            IStaticType,
            ReadOnlyGenericParameterDeclaration,
            ReadOnlyTypeReference,
            ReadOnlyDelegateParameter>
    {
        private readonly StaticClassNestedDelegate nestedDelegate;
        private readonly IReadOnlyList<ReadOnlyGenericParameterDeclaration> genericParameters;
        private readonly IReadOnlyList<ReadOnlyDelegateParameter> parameters;
        private readonly ReadOnlyTypeReference returnType;

        public ReadOnlyStaticClassNestedDelegate(StaticClassNestedDelegate nestedDelegate)
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

        public override IStaticType DeclaringType
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

        public override StaticClassMemberVisibilityModifier Visibility
        {
            get { return nestedDelegate.Visibility; }
        }
    }
}
