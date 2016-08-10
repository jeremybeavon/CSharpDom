using CSharpDom.TestTarget.SealedClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_Methods_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithMethodWith1AttributeUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWith1GenericParameterUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWith1ReturnAttributeUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWith2GenericParametersUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithGenericParameterBaseSealedClassConstraintUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithMethodWithGenericParameterBaseSealedClassConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithGenericParameterSealedClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithMethodWithGenericParameterSealedClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithGenericParameterSealedClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithMethodWithGenericParameterSealedClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithGenericParameterSealedClassConstraintUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithMethodWithGenericParameterSealedClassConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithInternalMethodUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithInternalMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNewMethodUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNewStaticMethodUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestSealedClassWithOverrideMethodUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithParametersWithAttributesUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithParametersWithModifiersUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithPrivateMethodUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedMethodUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedInternalMethodUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestSealedClassWithPublicMethodUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithPublicMethod));
        }

        [TestMethod]
        public void TestSealedClassWithSealedOverrideMethodUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestSealedClassWithStaticMethodUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithStaticMethod));
        }
    }
}
