using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class CombinedFilterTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void CombinedFilterSimplePasses()
        {
            int[] input = { 1, 3, 5, 7, 9 };
            int[] output = CombinedFilter.combinedFilter(input);
            int[] expected = { 20, 22, 16, 18, 28 };

            CollectionAssert.AreEqual(expected, output);
        }

        // A Test behaves as an ordinary method
        [Test]
        public void CombinedFilterNegativePasses()
        {
            int[] input = { -1, -3, -5, -7, -9 };
            int[] output = CombinedFilter.combinedFilter(input);
            int[] expected = { -22, -23, -17, -19, -29 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}
