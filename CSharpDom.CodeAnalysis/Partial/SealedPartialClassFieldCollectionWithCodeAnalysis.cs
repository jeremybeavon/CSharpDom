using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class SealedPartialClassFieldCollectionWithCodeAnalysis :
        EditableClassFieldCollection<SealedPartialClassFieldWithCodeAnalysis, SealedPartialClassConstantWithCodeAnalysis>
    {
        private readonly WrappedCollection<
            SealedClassConstantWithCodeAnalysis,
            SealedPartialClassConstantWithCodeAnalysis> constants;
        private readonly WrappedCollection<
            SealedClassFieldWithCodeAnalysis,
            SealedPartialClassFieldWithCodeAnalysis> fields;

        public SealedPartialClassFieldCollectionWithCodeAnalysis(SealedClassFieldCollectionWithCodeAnalysis fieldCollection)
        {
            constants = new WrappedCollection<SealedClassConstantWithCodeAnalysis, SealedPartialClassConstantWithCodeAnalysis>(
                fieldCollection.Constants,
                parent => new SealedPartialClassConstantWithCodeAnalysis(parent),
                child => child.Constant,
                value => fieldCollection.Constants = value);
            fields = new WrappedCollection<SealedClassFieldWithCodeAnalysis, SealedPartialClassFieldWithCodeAnalysis>(
                fieldCollection.Fields,
                parent => new SealedPartialClassFieldWithCodeAnalysis(parent),
                child => child.Field,
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
