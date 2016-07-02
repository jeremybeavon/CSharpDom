using CSharpDom.TestTarget.Structs.NestedStructs.NestedStructs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStructs_NestedStructs_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedStructWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedStructWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedStructWith1GenericParameterUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedStructWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedStructWith1ImplementedInterfaceUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedStructWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedStructWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedStructWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedStructWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedStructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedStructWith2GenericParametersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedStructWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedStructWith2ImplementedInterfacesUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedStructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedStructWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedStructWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedStructWithGenericParameterClassConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedStructWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedStructWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedStructWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedStructWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedStructWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedStructWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedStructWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedStructWithGenericParameterStructConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedStructWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithInternalNestedStructUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithInternalNestedStruct));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPrivateNestedStructUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPrivateNestedStruct));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPublicNestedStructUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPublicNestedStruct));
        }
    }
}
