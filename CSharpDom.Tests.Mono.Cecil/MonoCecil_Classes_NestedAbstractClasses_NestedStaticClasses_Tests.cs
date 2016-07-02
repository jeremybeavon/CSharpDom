using CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedStaticClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedAbstractClasses_NestedStaticClasses_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedStaticClassWith1AttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedStaticClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedStaticClassWith1GenericParameterUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedStaticClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedStaticClassWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedStaticClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedStaticClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedStaticClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedStaticClassWith2GenericParametersUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedStaticClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithInternalNestedStaticClassUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalNestedStaticClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPrivateNestedStaticClassUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateNestedStaticClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedNestedStaticClassUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedNestedStaticClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedInternalNestedStaticClassUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalNestedStaticClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPublicNestedStaticClassUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicNestedStaticClass));
        }
    }
}
