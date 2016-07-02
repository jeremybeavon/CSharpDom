using CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedInterfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedAbstractClasses_NestedInterfaces_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedInterfaceWith1AttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedInterfaceWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedInterfaceWith1GenericParameterUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedInterfaceWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedInterfaceWith1ImplementedInterfaceUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedInterfaceWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedInterfaceWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedInterfaceWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedInterfaceWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedInterfaceWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedInterfaceWith2GenericParametersUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedInterfaceWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedInterfaceWith2ImplementedInterfacesUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedInterfaceWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedInternalInterfaceUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedInternalInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedPrivateInterfaceUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedPrivateInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedProtectedInterfaceUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedProtectedInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedProtectedInternalInterfaceUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedProtectedInternalInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPublicNestedInterfaceUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicNestedInterface));
        }
    }
}
