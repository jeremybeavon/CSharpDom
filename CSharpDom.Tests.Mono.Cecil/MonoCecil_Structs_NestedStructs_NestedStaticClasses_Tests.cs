using CSharpDom.TestTarget.Structs.NestedStructs.NestedStaticClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedStructs_NestedStaticClasses_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedStaticClassWith1AttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedStaticClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedStaticClassWith1GenericParameterUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedStaticClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedStaticClassWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedStaticClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedStaticClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedStaticClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedStaticClassWith2GenericParametersUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedStaticClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedStaticClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedStaticClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedStaticClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedStaticClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedStaticClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedStaticClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedStaticClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedStaticClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedStaticClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedStaticClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedStaticClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithInternalNestedStaticClassUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithInternalNestedStaticClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPrivateNestedStaticClassUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPrivateNestedStaticClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPublicNestedStaticClassUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPublicNestedStaticClass));
        }
    }
}
