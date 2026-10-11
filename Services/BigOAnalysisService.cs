using System.Numerics;

namespace DSALabsApi.Services
{
    public class BigOAnalysisService
    {
        private readonly MultiplicationService _mult;
        public BigOAnalysisService(MultiplicationService mult) => _mult = mult;

        public object Report() => new
        {
            traditional = new
            {
                algorithm = "Schoolbook (grade-school) multiplication",
                timeComplexity = "O(n²)",
                spaceComplexity = "O(1) auxiliary",
                nMeaning = "number of digits in the operands",
                reason = "Each of the n digits of one operand is multiplied by each of the n digits of the other."
            },
            karatsuba = new
            {
                algorithm = "Karatsuba divide-and-conquer multiplication",
                timeComplexity = "O(n^log₂3) ≈ O(n^1.585)",
                spaceComplexity = "O(n) due to recursion stack",
                nMeaning = "number of digits in the operands",
                reason = "Splits each number in half, performs 3 recursive multiplications instead of 4, then combines."
            },
            comparison = "For small inputs (n < ~100), schoolbook is often faster due to lower overhead. " +
                         "Karatsuba overtakes it asymptotically as n grows."
        };

        public object SummaryFor(long a, long b)
        {
            var t = _mult.TraditionalMultiply(a, b);
            var k = _mult.Karatsuba(a, b);
            return new
            {
                a, b,
                traditionalResult = t.ToString(),
                karatsubaResult = k.ToString(),
                match = t == k,
                notes = new[]
                {
                    $"Traditional uses ~{a.ToString().Length * b.ToString().Length} digit-multiplications.",
                    $"Karatsuba uses ~3 * log(n) recursive multiplications at each split level."
                }
            };
        }

        
        // ================= NEW TASK: DSA COMPLEXITY ANALYSIS =================

        // Returns time and space complexity explanations
        // for the four newly added DSA operations.
        public object DSAOperationsReport()
        {
            return new
            {
                arrayReversal = new
                {
                    algorithm = "Reverse Array",
                    dataStructure = "Array",
                    timeComplexity = "O(n)",
                    spaceComplexity = "O(1)",
                    explanation =
                        "Uses two pointers, left and right, to swap " +
                        "elements until both pointers meet. " +
                        "Each element is processed at most once.",
                    bestCase = "O(n) for n >= 2",
                    worstCase = "O(n)",
                    additionalSpace =
                        "Only three integer variables are used: " +
                        "left, right and temp."
                },

                singlyLinkedListMiddle = new
                {
                    algorithm = "Find Middle Node",
                    dataStructure = "Singly Linked List",
                    timeComplexity = "O(n)",
                    spaceComplexity = "O(1)",
                    explanation =
                        "Uses slow and fast pointers. " +
                        "The slow pointer moves one node at a time, " +
                        "while the fast pointer moves two nodes. " +
                        "When fast reaches the end, slow is at the middle.",
                    bestCase = "O(1) for an empty or single-node list",
                    worstCase = "O(n)",
                    additionalSpace =
                        "Only two pointer variables are used: " +
                        "slow and fast."
                },

                doublyLinkedListReversal = new
                {
                    algorithm = "Reverse Doubly Linked List",
                    dataStructure = "Doubly Linked List",
                    timeComplexity = "O(n)",
                    spaceComplexity = "O(1)",
                    explanation =
                        "Traverses every node and swaps its Next " +
                        "and Prev references. After traversal, " +
                        "the head and tail references are swapped.",
                    bestCase = "O(1) for an empty list",
                    worstCase = "O(n)",
                    additionalSpace =
                        "Uses a constant number of temporary " +
                        "node references. No additional list is created."
                },

                circularLinkedListInsertion = new
                {
                    algorithm = "Insert at Position",
                    dataStructure = "Circular Linked List",
                    timeComplexity = "O(n)",
                    spaceComplexity = "O(1)",
                    explanation =
                        "Traverses the circular list to locate " +
                        "the insertion point. Then updates node " +
                        "references while preserving the circular connection.",
                    bestCase = "O(1) when inserting into an empty list",
                    worstCase = "O(n)",
                    additionalSpace =
                        "Creates only the node being inserted " +
                        "and uses a constant number of references."
                }
            };
        }

    }
}
