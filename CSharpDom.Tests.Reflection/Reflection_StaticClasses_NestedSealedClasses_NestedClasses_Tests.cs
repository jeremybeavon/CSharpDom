using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedSealedClasses_NestedClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedClassWith1AttributeUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedClassWith1GenericParameterUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedClassWith1ImplementedInterfaceUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedClassWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedClassWith2GenericParametersUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedClassWith2ImplementedInterfacesUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedClassWithBaseClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedClassWithGenericParameterClassConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedClassWithGenericParameterStructConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithInternalNestedClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithInternalNestedClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithPrivateNestedClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPrivateNestedClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithProtectedNestedClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedNestedClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithProtectedInternalNestedClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedInternalNestedClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithPublicNestedClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPublicNestedClass));
        }
    }
}
