using System.Collections.Generic;
using CSharpDom.Editable;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class SealedPartialClassFieldCollectionWithCodeAnalysis :
        EditableClassFieldCollection<SealedPartialClassFieldWithCodeAnalysis, SealedPartialClassConstantWithCodeAnalysis>
    {
        private readonly WrappedCollection<
            ClassConstantWithCodeAnalysis,
            SealedPartialClassConstantWithCodeAnalysis> constants;
        private readonly WrappedCollection<ClassFieldWithCodeAnalysis, SealedPartialClassFieldWithCodeAnalysis> fields;

        public SealedPartialClassFieldCollectionWithCodeAnalysis(ClassFieldCollectionWithCodeAnalysis fieldCollection)
        {
            constants = new WrappedCollection<ClassConstantWithCodeAnalysis, SealedPartialClassConstantWithCodeAnalysis>(
                fieldCollection.Constants,
                parent => new SealedPartialClassConstantWithCodeAnalysis(parent),
                child => child.InternalConstant,
                value => fieldCollection.Constants = value);
            fields = new WrappedCollection<ClassFieldWithCodeAnalysis, SealedPartialClassFieldWithCodeAnalysis>(
                fieldCollection.Fields,
                parent => new SealedPartialClassFieldWithCodeAnalysis(parent),
                child => child.InternalField,
                value => fieldCollection.Fields = value);
        }

        public override ICollection<SealedPartialClassConstantWithCodeAnalysis> Constants
        {
            get { return constants; }
            set { constants.Replace(value); }
        }

        public override ICollection<SealedPartialClassFieldWithCodeAnalysis> Fields
        {
            get { return fields; }
            set { fields.Replace(value); }
        }
    }
}
