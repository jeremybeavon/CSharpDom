using CSharpDom.TestTarget.Classes.NestedInterfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedInterfaces_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedInterfaceWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedInterfaceWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedInterfaceWith1GenericParameterUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedInterfaceWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedInterfaceWith1ImplementedInterfaceUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedInterfaceWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedInterfaceWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedInterfaceWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedInterfaceWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedInterfaceWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedInterfaceWith2GenericParametersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedInterfaceWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedInterfaceWith2ImplementedInterfacesUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedInterfaceWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestClassWithNestedInterfaceWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedInterfaceWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedInterfaceWithGenericParameterClassConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedInterfaceWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedInterfaceWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedInterfaceWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedInterfaceWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedInterfaceWithGenericParameterStructConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedInterfaceWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedProtectedInterfaceUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedProtectedInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedPrivateInterfaceUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedPrivateInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedProtectedInternalInterfaceUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedProtectedInternalInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedInternalInterfaceUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedInternalInterface));
        }

        [TestMethod]
        public async Task TestClassWithPublicNestedInterfaceUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithPublicNestedInterface));
        }
    }
}
