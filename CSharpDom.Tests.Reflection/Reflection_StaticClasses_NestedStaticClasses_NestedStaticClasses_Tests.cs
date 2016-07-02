using CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedStaticClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedStaticClasses_NestedStaticClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedStaticClassWith1AttributeUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedStaticClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedStaticClassWith1GenericParameterUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedStaticClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedStaticClassWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedStaticClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedStaticClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedStaticClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedStaticClassWith2GenericParametersUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedStaticClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterStructConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithInternalNestedStaticClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithInternalNestedStaticClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithPrivateNestedStaticClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPrivateNestedStaticClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithProtectedNestedStaticClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithProtectedNestedStaticClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithProtectedInternalNestedStaticClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithProtectedInternalNestedStaticClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithPublicNestedStaticClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPublicNestedStaticClass));
        }
    }
}
