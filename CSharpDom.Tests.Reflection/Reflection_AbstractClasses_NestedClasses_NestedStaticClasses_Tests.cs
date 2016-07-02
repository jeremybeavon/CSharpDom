using CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedStaticClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedClasses_NestedStaticClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNestedStaticClassWith1AttributeUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedStaticClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNestedStaticClassWith1GenericParameterUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedStaticClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNestedStaticClassWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedStaticClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNestedStaticClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedStaticClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNestedStaticClassWith2GenericParametersUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedStaticClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNestedStaticClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedStaticClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNestedStaticClassWithGenericParameterClassConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedStaticClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNestedStaticClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNestedStaticClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedStaticClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNestedStaticClassWithGenericParameterStructConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedStaticClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithInternalNestedStaticClassUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithInternalNestedStaticClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithPrivateNestedStaticClassUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPrivateNestedStaticClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithProtectedNestedStaticClassUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedNestedStaticClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithProtectedInternalNestedStaticClassUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedInternalNestedStaticClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithPublicNestedStaticClassUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPublicNestedStaticClass));
        }
    }
}
