using System.Collections.Generic;
using CSharpDom.Editable;

namespace CSharpDom.CodeAnalysis
{
    public sealed class SealedClassFieldCollectionWithCodeAnalysis :
        EditableClassFieldCollection<SealedClassFieldWithCodeAnalysis, SealedClassConstantWithCodeAnalysis>
    {
        private readonly WrappedCollection<ClassConstantWithCodeAnalysis, SealedClassConstantWithCodeAnalysis> constants;
        private readonly WrappedCollection<ClassFieldWithCodeAnalysis, SealedClassFieldWithCodeAnalysis> fields;

        public SealedClassFieldCollectionWithCodeAnalysis(ClassFieldCollectionWithCodeAnalysis fieldCollection)
        {
            constants = new WrappedCollection<ClassConstantWithCodeAnalysis, SealedClassConstantWithCodeAnalysis>(
                fieldCollection.Constants,
                parent => new SealedClassConstantWithCodeAnalysis(parent),
                child => child.InternalConstant,
                value => fieldCollection.Constants = value);
            fields = new WrappedCollection<ClassFieldWithCodeAnalysis, SealedClassFieldWithCodeAnalysis>(
                fieldCollection.Fields,
                parent => new SealedClassFieldWithCodeAnalysis(parent),
                child => child.InternalField,
                value => fieldCollection.Fields = value);
        }

        public override ICollection<SealedClassConstantWithCodeAnalysis> Constants
        {
            get { return constants; }
            set { constants.Replace(value); }
        }

        public override ICollection<SealedClassFieldWithCodeAnalysis> Fields
        {
            get { return fields; }
            set { fields.Replace(value); }
        }
    }
}
