using CSharpDom.TestTarget.StaticClasses.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedClassWith1AttributeUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWith1GenericParameterUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWith1ImplementedInterfaceUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWith2GenericParametersUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWith2ImplementedInterfacesUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithBaseClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithGenericParameterClassConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithGenericParameterStructConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithInternalNestedClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithInternalNestedClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithPrivateNestedClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPrivateNestedClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithProtectedNestedClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithProtectedNestedClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithProtectedInternalNestedClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithProtectedInternalNestedClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithPublicNestedClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPublicNestedClass));
        }
    }
}
