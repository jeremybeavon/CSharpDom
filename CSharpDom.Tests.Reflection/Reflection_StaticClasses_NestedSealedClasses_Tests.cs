using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedSealedClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWith1AttributeUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWith1GenericParameterUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWith1ImplementedInterfaceUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWith2GenericParametersUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWith2ImplementedInterfacesUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithBaseClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithGenericParameterClassConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithGenericParameterStructConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithInternalNestedSealedClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithInternalNestedSealedClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithPrivateNestedSealedClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPrivateNestedSealedClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithProtectedNestedSealedClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithProtectedNestedSealedClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithProtectedInternalNestedSealedClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithProtectedInternalNestedSealedClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithPublicNestedSealedClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPublicNestedSealedClass));
        }
    }
}
