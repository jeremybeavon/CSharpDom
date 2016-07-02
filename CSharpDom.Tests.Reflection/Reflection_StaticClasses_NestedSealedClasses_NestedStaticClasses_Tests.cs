using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedStaticClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedSealedClasses_NestedStaticClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedStaticClassWith1AttributeUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStaticClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedStaticClassWith1GenericParameterUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStaticClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedStaticClassWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStaticClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedStaticClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStaticClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedStaticClassWith2GenericParametersUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStaticClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterClassConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterStructConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithInternalNestedStaticClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithInternalNestedStaticClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithPrivateNestedStaticClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPrivateNestedStaticClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithProtectedNestedStaticClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedNestedStaticClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithProtectedInternalNestedStaticClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedInternalNestedStaticClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithPublicNestedStaticClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPublicNestedStaticClass));
        }
    }
}
