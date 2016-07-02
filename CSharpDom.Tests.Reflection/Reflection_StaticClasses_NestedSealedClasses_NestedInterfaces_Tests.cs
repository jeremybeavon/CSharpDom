using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedInterfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedSealedClasses_NestedInterfaces_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedInterfaceWith1AttributeUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedInterfaceWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedInterfaceWith1GenericParameterUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedInterfaceWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedInterfaceWith1ImplementedInterfaceUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedInterfaceWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedInterfaceWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedInterfaceWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedInterfaceWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedInterfaceWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedInterfaceWith2GenericParametersUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedInterfaceWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedInterfaceWith2ImplementedInterfacesUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedInterfaceWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterClassConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterStructConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedInternalInterfaceUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedInternalInterface));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedPrivateInterfaceUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedPrivateInterface));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedProtectedInterfaceUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedProtectedInterface));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedProtectedInternalInterfaceUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedProtectedInternalInterface));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithPublicNestedInterfaceUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPublicNestedInterface));
        }
    }
}
