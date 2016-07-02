using CSharpDom.TestTarget.Classes.NestedClasses.NestedInterfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedClasses_NestedInterfaces_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedInterfaceWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedInterfaceWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedInterfaceWith1GenericParameterUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedInterfaceWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedInterfaceWith1ImplementedInterfaceUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedInterfaceWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedInterfaceWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedInterfaceWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedInterfaceWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedInterfaceWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedInterfaceWith2GenericParametersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedInterfaceWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedInterfaceWith2ImplementedInterfacesUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedInterfaceWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedInterfaceWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedInterfaceWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedInterfaceWithGenericParameterClassConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedInterfaceWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedInterfaceWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedInterfaceWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedInterfaceWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedInterfaceWithGenericParameterStructConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedInterfaceWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedInternalInterfaceUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedInternalInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedPrivateInterfaceUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedPrivateInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedProtectedInterfaceUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedProtectedInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedProtectedInternalInterfaceUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedProtectedInternalInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPublicNestedInterfaceUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPublicNestedInterface));
        }
    }
}
