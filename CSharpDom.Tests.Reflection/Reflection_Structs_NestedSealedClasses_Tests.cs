using CSharpDom.TestTarget.Structs.NestedSealedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedSealedClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedSealedClassWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWith1GenericParameterUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWith1ImplementedInterfaceUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWith2GenericParametersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWith2ImplementedInterfacesUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithBaseClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithGenericParameterClassConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithGenericParameterStructConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStructWithInternalNestedSealedClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithInternalNestedSealedClass));
        }

        [TestMethod]
        public async Task TestStructWithPrivateNestedSealedClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithPrivateNestedSealedClass));
        }

        [TestMethod]
        public async Task TestStructWithPublicNestedSealedClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithPublicNestedSealedClass));
        }
    }
}
