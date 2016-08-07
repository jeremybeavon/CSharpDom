using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class Fields<TField, TConstant, TType>
        where TType : ITypeWithReflection
    {
        public Fields(
            TType declaringType,
            IFieldFactory<TField, TConstant, TType> fieldFactory)
        {
            List<TField> fields = new List<TField>();
            List<TConstant> constants = new List<TConstant>();
            foreach (FieldInfo fieldDefinition in
                declaringType.Type.GetAllFields().Where(field => !field.IsDefined(typeof(CompilerGeneratedAttribute))))
            {
                if (fieldDefinition.IsInitOnly)
                {
                    constants.Add(fieldFactory.CreateConstant(declaringType, fieldDefinition));
                }
                else
                {
                    fields.Add(fieldFactory.CreateField(declaringType, fieldDefinition));
                }
            }

            FieldsWithReflection = fields;
            ConstantsWithReflection = constants;
        }

        public IReadOnlyCollection<TField> FieldsWithReflection { get; private set; }

        public IReadOnlyCollection<TConstant> ConstantsWithReflection { get; private set; }
    }
}
