using CSharpDom.TestTarget.Classes.NestedClasses.NestedStaticClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedClasses_NestedStaticClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedStaticClassWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedStaticClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedStaticClassWith1GenericParameterUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedStaticClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedStaticClassWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedStaticClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedStaticClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedStaticClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedStaticClassWith2GenericParametersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedStaticClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedStaticClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedStaticClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedStaticClassWithGenericParameterClassConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedStaticClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedStaticClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedStaticClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedStaticClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedStaticClassWithGenericParameterStructConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedStaticClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithInternalNestedStaticClassUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithInternalNestedStaticClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPrivateNestedStaticClassUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPrivateNestedStaticClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedNestedStaticClassUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedNestedStaticClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedInternalNestedStaticClassUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalNestedStaticClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPublicNestedStaticClassUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPublicNestedStaticClass));
        }
    }
}
