using CSharpDom.TestTarget.StaticClasses.NestedStaticClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedStaticClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWith1AttributeUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWith1GenericParameterUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWith2GenericParametersUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithGenericParameterClassConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithGenericParameterStructConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithInternalNestedStaticClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithInternalNestedStaticClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithPrivateNestedStaticClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPrivateNestedStaticClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithProtectedNestedStaticClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithProtectedNestedStaticClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithProtectedInternalNestedStaticClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithProtectedInternalNestedStaticClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithPublicNestedStaticClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPublicNestedStaticClass));
        }
    }
}
