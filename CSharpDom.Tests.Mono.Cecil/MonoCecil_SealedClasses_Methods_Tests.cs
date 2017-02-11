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
            TestSealedClass(typeof(SealedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWith1GenericParameterUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWith1ReturnAttributeUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWith2GenericParametersUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithInternalMethodUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithInternalMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNewMethodUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNewMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNewStaticMethodUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestSealedClassWithOverrideMethodUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithParametersWithAttributesUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithParametersWithModifiersUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithPrivateMethodUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedMethodUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedInternalMethodUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestSealedClassWithPublicMethodUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithPublicMethod));
        }

        [TestMethod]
        public void TestSealedClassWithSealedOverrideMethodUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestSealedClassWithStaticMethodUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithStaticMethod));
        }
    }
}
