using CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedStaticClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedStaticClasses_NestedStaticClasses_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedStaticClassWith1AttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStaticClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedStaticClassWith1GenericParameterUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStaticClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedStaticClassWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStaticClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedStaticClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStaticClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedStaticClassWith2GenericParametersUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStaticClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithInternalNestedStaticClassUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithInternalNestedStaticClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithPrivateNestedStaticClassUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithPrivateNestedStaticClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithProtectedNestedStaticClassUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithProtectedNestedStaticClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithProtectedInternalNestedStaticClassUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithProtectedInternalNestedStaticClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithPublicNestedStaticClassUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithPublicNestedStaticClass));
        }
    }
}
