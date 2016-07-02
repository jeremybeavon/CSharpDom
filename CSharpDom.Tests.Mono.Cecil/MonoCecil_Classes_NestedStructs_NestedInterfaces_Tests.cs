using CSharpDom.TestTarget.Classes.NestedStructs.NestedInterfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedStructs_NestedInterfaces_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedInterfaceWith1AttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedInterfaceWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedInterfaceWith1GenericParameterUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedInterfaceWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedInterfaceWith1ImplementedInterfaceUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedInterfaceWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedInterfaceWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedInterfaceWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedInterfaceWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedInterfaceWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedInterfaceWith2GenericParametersUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedInterfaceWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedInterfaceWith2ImplementedInterfacesUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedInterfaceWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedInterfaceWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedInterfaceWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedInterfaceWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedInterfaceWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedInterfaceWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedInterfaceWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedInterfaceWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedInterfaceWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedInterfaceWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedInterfaceWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedInterfaceWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedInternalInterfaceUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedInternalInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedPrivateInterfaceUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedPrivateInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPublicNestedInterfaceUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPublicNestedInterface));
        }
    }
}
