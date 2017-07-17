using System.Collections.Generic;
using CSharpDom.Editable;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class PartialClassFieldCollectionWithCodeAnalysis :
        EditableClassFieldCollection<PartialClassFieldWithCodeAnalysis, PartialClassConstantWithCodeAnalysis>
    {
        private readonly WrappedCollection<
            ClassConstantWithCodeAnalysis,
            PartialClassConstantWithCodeAnalysis> constants;
        private readonly WrappedCollection<ClassFieldWithCodeAnalysis, PartialClassFieldWithCodeAnalysis> fields;

        public PartialClassFieldCollectionWithCodeAnalysis(ClassFieldCollectionWithCodeAnalysis fieldCollection)
        {
            constants = new WrappedCollection<ClassConstantWithCodeAnalysis, PartialClassConstantWithCodeAnalysis>(
                fieldCollection.Constants,
                parent => new PartialClassConstantWithCodeAnalysis(parent),
                child => child.InternalConstant,
                value => fieldCollection.Constants = value);
            fields = new WrappedCollection<ClassFieldWithCodeAnalysis, PartialClassFieldWithCodeAnalysis>(
                fieldCollection.Fields,
                parent => new PartialClassFieldWithCodeAnalysis(parent),
                child => child.InternalField,
                value => fieldCollection.Fields = value);
        }

        public override ICollection<PartialClassConstantWithCodeAnalysis> Constants
        {
            get { return constants; }
            set { constants.Replace(value); }
        }

        public override ICollection<PartialClassFieldWithCodeAnalysis> Fields
        {
            get { return fields; }
            set { fields.Replace(value); }
        }
    }
}
