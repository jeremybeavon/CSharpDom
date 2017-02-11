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
            TestClass(typeof(ClassWithNestedSealedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWith1GenericParameterUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWith1ReturnAttributeUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWith2GenericParametersUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithInternalMethodUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithInternalMethod));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewMethodUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithNewMethod));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticMethodUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithOverrideMethodUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithParametersWithAttributesUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithParametersWithModifiersUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivateMethodUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedMethodUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalMethodUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicMethodUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithPublicMethod));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithSealedOverrideMethodUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticMethodUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithStaticMethod));
        }
    }
}
