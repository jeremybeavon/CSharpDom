using CSharpDom.TestTarget.Classes.NestedSealedClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedSealedClasses_Methods_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWith1AttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWith1GenericParameterUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWith1ReturnAttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWith2GenericParametersUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithInternalMethodUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalMethod));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewMethodUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewMethod));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticMethodUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithOverrideMethodUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithParametersWithAttributesUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithParametersWithModifiersUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivateMethodUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedMethodUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalMethodUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicMethodUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicMethod));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithSealedOverrideMethodUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticMethodUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticMethod));
        }
    }
}
