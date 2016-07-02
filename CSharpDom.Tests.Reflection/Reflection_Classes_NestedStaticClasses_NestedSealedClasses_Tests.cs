using CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedSealedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStaticClasses_NestedSealedClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedSealedClassWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedSealedClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedSealedClassWith1GenericParameterUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedSealedClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedSealedClassWith1ImplementedInterfaceUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedSealedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedSealedClassWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedSealedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedSealedClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedSealedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedSealedClassWith2GenericParametersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedSealedClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedSealedClassWith2ImplementedInterfacesUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedSealedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedSealedClassWithBaseClassUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedSealedClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterClassConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterStructConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithInternalNestedSealedClassUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithInternalNestedSealedClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithPrivateNestedSealedClassUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithPrivateNestedSealedClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithProtectedNestedSealedClassUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithProtectedNestedSealedClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithProtectedInternalNestedSealedClassUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithProtectedInternalNestedSealedClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithPublicNestedSealedClassUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithPublicNestedSealedClass));
        }
    }
}
