using CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedStaticClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedStaticClasses_NestedStaticClasses_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedStaticClassWith1AttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedStaticClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedStaticClassWith1GenericParameterUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedStaticClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedStaticClassWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedStaticClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedStaticClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedStaticClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedStaticClassWith2GenericParametersUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedStaticClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedStaticClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedStaticClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedStaticClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedStaticClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedStaticClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedStaticClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedStaticClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithInternalNestedStaticClassUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithInternalNestedStaticClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPrivateNestedStaticClassUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPrivateNestedStaticClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithProtectedNestedStaticClassUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithProtectedNestedStaticClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithProtectedInternalNestedStaticClassUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithProtectedInternalNestedStaticClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPublicNestedStaticClassUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPublicNestedStaticClass));
        }
    }
}
