using CSharpDom.TestTarget.Structs.NestedClasses.NestedStructs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedClasses_NestedStructs_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedStructWith1AttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedStructWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedStructWith1GenericParameterUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedStructWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedStructWith1ImplementedInterfaceUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedStructWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedStructWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedStructWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedStructWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedStructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedStructWith2GenericParametersUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedStructWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedStructWith2ImplementedInterfacesUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedStructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedStructWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedStructWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedStructWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedStructWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedStructWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedStructWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedStructWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedStructWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedStructWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedStructWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedStructWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedStructWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithInternalNestedStructUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithInternalNestedStruct));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPrivateNestedStructUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPrivateNestedStruct));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedNestedStructUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedNestedStruct));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedInternalNestedStructUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalNestedStruct));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPublicNestedStructUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPublicNestedStruct));
        }
    }
}
