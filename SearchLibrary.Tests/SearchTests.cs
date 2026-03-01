using NUnit.Framework;
using NUnit.Framework.Legacy;
using SearchLibrary.Algorithms;

namespace SearchLibrary.Tests
{
    [TestFixture]
    public class SearchTests
    {
        private BinarySearch _binary;
        private LinearSearch _linear;
        private InterpolationSearch _interpolation;

        [SetUp]
        public void Setup()
        {
            _binary        = new BinarySearch();
            _linear        = new LinearSearch();
            _interpolation = new InterpolationSearch();
        }

        // ══════════════════════════════════
        // BINARY SEARCH TESTS (MC/DC)
        // Conditions:
        // C1: bottom <= top
        // C2: found == false
        // C3: elemArray[mid] == key
        // C4: elemArray[mid] < key
        // ══════════════════════════════════

        [Test, Category("BinarySearch"), Category("MC_DC")]
        public void Binary_KeyAtMiddle_Found()
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            ClassicAssert.AreEqual(2, _binary.Search(30, arr));
        }

        [Test, Category("BinarySearch"), Category("MC_DC")]
        public void Binary_KeyAtFirst_Found()
        {
            int[] arr = { 5, 15, 25, 35, 45 };
            ClassicAssert.AreEqual(0, _binary.Search(5, arr));
        }

        [Test, Category("BinarySearch"), Category("MC_DC")]
        public void Binary_KeyAtLast_Found()
        {
            int[] arr = { 5, 15, 25, 35, 45 };
            ClassicAssert.AreEqual(4, _binary.Search(45, arr));
        }

        [Test, Category("BinarySearch"), Category("MC_DC")]
        public void Binary_KeyNotPresent_ReturnsMinusOne()
        {
            int[] arr = { 2, 4, 6, 8, 10 };
            ClassicAssert.AreEqual(-1, _binary.Search(7, arr));
        }

        [Test, Category("BinarySearch"), Category("AllPaths")]
        public void Binary_EmptyArray_ReturnsMinusOne()
        {
            int[] arr = { };
            ClassicAssert.AreEqual(-1, _binary.Search(1, arr));
        }

        [Test, Category("BinarySearch"), Category("AllPaths")]
        public void Binary_SingleElement_Found()
        {
            ClassicAssert.AreEqual(0, _binary.Search(42, new int[] { 42 }));
        }

        [Test, Category("BinarySearch"), Category("AllPaths")]
        public void Binary_SingleElement_NotFound()
        {
            ClassicAssert.AreEqual(-1, _binary.Search(99, new int[] { 42 }));
        }

        // ══════════════════════════════════
        // LINEAR SEARCH TESTS (MC/DC)
        // Conditions:
        // C1: array null or empty
        // C2: i < array.Length
        // C3: array[i] == key
        // ══════════════════════════════════

        [Test, Category("LinearSearch"), Category("MC_DC")]
        public void Linear_KeyAtFirst_Found()
        {
            int[] arr = { 10, 20, 30 };
            ClassicAssert.AreEqual(0, _linear.Search(10, arr));
        }

        [Test, Category("LinearSearch"), Category("MC_DC")]
        public void Linear_KeyAtLast_Found()
        {
            int[] arr = { 10, 20, 30 };
            ClassicAssert.AreEqual(2, _linear.Search(30, arr));
        }

        [Test, Category("LinearSearch"), Category("MC_DC")]
        public void Linear_KeyNotPresent_ReturnsMinusOne()
        {
            int[] arr = { 10, 20, 30 };
            ClassicAssert.AreEqual(-1, _linear.Search(99, arr));
        }

        [Test, Category("LinearSearch"), Category("MC_DC")]
        public void Linear_NullArray_ReturnsMinusOne()
        {
            ClassicAssert.AreEqual(-1, _linear.Search(5, null));
        }

        [Test, Category("LinearSearch"), Category("AllPaths")]
        public void Linear_EmptyArray_ReturnsMinusOne()
        {
            ClassicAssert.AreEqual(-1, _linear.Search(5, new int[] { }));
        }

        [Test, Category("LinearSearch"), Category("AllPaths")]
        public void Linear_UnsortedArray_Found()
        {
            int[] arr = { 50, 10, 30, 70, 20 };
            ClassicAssert.AreEqual(2, _linear.Search(30, arr));
        }

        // ══════════════════════════════════
        // INTERPOLATION SEARCH TESTS (MC/DC)
        // Conditions:
        // C1: array null or empty
        // C2: low <= high
        // C3: key >= arr[low]
        // C4: key <= arr[high]
        // C5: arr[high] == arr[low]
        // C6: arr[low] == key
        // C7: arr[pos] == key
        // C8: arr[pos] < key
        // ══════════════════════════════════

        [Test, Category("InterpolationSearch"), Category("MC_DC")]
        public void Interpolation_KeyPresent_Found()
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            ClassicAssert.AreEqual(2, _interpolation.Search(30, arr));
        }

        [Test, Category("InterpolationSearch"), Category("MC_DC")]
        public void Interpolation_KeyNotPresent_ReturnsMinusOne()
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            ClassicAssert.AreEqual(-1, _interpolation.Search(25, arr));
        }

        [Test, Category("InterpolationSearch"), Category("MC_DC")]
        public void Interpolation_KeyBelowMin_ReturnsMinusOne()
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            ClassicAssert.AreEqual(-1, _interpolation.Search(5, arr));
        }

        [Test, Category("InterpolationSearch"), Category("MC_DC")]
        public void Interpolation_KeyAboveMax_ReturnsMinusOne()
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            ClassicAssert.AreEqual(-1, _interpolation.Search(60, arr));
        }

        [Test, Category("InterpolationSearch"), Category("MC_DC")]
        public void Interpolation_AllSame_KeyFound()
        {
            int[] arr = { 7, 7, 7, 7 };
            ClassicAssert.AreEqual(0, _interpolation.Search(7, arr));
        }

        [Test, Category("InterpolationSearch"), Category("MC_DC")]
        public void Interpolation_AllSame_KeyNotFound()
        {
            int[] arr = { 7, 7, 7, 7 };
            ClassicAssert.AreEqual(-1, _interpolation.Search(9, arr));
        }

        [Test, Category("InterpolationSearch"), Category("AllPaths")]
        public void Interpolation_NullArray_ReturnsMinusOne()
        {
            ClassicAssert.AreEqual(-1, _interpolation.Search(5, null));
        }

        [Test, Category("InterpolationSearch"), Category("MC_DC")]
        public void Interpolation_KeyUpperHalf_Found()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ClassicAssert.AreEqual(8, _interpolation.Search(9, arr));
        }

        [Test, Category("InterpolationSearch"), Category("MC_DC")]
        public void Interpolation_KeyLowerHalf_Found()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ClassicAssert.AreEqual(1, _interpolation.Search(2, arr));
        }
    }
}