using CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedInterfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedSealedClasses_NestedInterfaces_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedInterfaceWith1AttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedInterfaceWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedInterfaceWith1GenericParameterUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedInterfaceWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedInterfaceWith1ImplementedInterfaceUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedInterfaceWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedInterfaceWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedInterfaceWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedInterfaceWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedInterfaceWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedInterfaceWith2GenericParametersUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedInterfaceWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedInterfaceWith2ImplementedInterfacesUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedInterfaceWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedInternalInterfaceUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedInternalInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedPrivateInterfaceUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedPrivateInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedProtectedInterfaceUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedProtectedInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedProtectedInternalInterfaceUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedProtectedInternalInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPublicNestedInterfaceUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicNestedInterface));
        }
    }
}
