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
    public sealed class ReadOnlyStructNestedEnum :
        AbstractNestedEnum<AttributeGroupNotSupported, IType, ReadOnlyEnumField>
    {
        private readonly StructNestedEnum nestedEnum;
        private readonly IReadOnlyList<ReadOnlyEnumField> enumMembers;

        public ReadOnlyStructNestedEnum(StructNestedEnum nestedEnum)
        {
            this.nestedEnum = nestedEnum;
            enumMembers = nestedEnum.Fields.ToArray(field => new ReadOnlyEnumField(field, true));
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override IType DeclaringType
        {
            get { return null; }
        }

        public override IReadOnlyList<ReadOnlyEnumField> EnumMembers
        {
            get { return enumMembers; }
        }

        public override string Name
        {
            get { return nestedEnum.Name; }
        }

        public override MemberVisibilityModifier Visibility
        {
            get { return ReadOnlyStruct.GetVisibility(nestedEnum.Visibility); }
        }
    }
}
