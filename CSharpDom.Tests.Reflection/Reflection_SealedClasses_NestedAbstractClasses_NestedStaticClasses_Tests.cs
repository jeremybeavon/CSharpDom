using CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedStaticClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedAbstractClasses_NestedStaticClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNestedStaticClassWith1AttributeUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedStaticClassWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNestedStaticClassWith1GenericParameterUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedStaticClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNestedStaticClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedStaticClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNestedStaticClassWith2GenericParametersUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedStaticClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterClassConstraintUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterStructConstraintUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithInternalNestedStaticClassUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithInternalNestedStaticClass));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPrivateNestedStaticClassUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPrivateNestedStaticClass));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedNestedStaticClassUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedNestedStaticClass));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedInternalNestedStaticClassUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedInternalNestedStaticClass));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPublicNestedStaticClassUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPublicNestedStaticClass));
        }
    }
}
