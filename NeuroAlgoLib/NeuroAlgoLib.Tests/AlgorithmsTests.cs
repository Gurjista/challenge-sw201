namespace NeuroAlgoLib.Tests;

[TestFixture]
public class AlgorithmsTests
{
    [Test]
    public void FibonacciRecursiveTest()
    {
        Assert.Multiple(() =>
        {
            Assert.That(Algorithms.FibonacciRecursive(0), Is.EqualTo(0));
            Assert.That(Algorithms.FibonacciRecursive(1), Is.EqualTo(1));
            Assert.That(Algorithms.FibonacciRecursive(2), Is.EqualTo(1));
            Assert.That(Algorithms.FibonacciRecursive(3), Is.EqualTo(2));
            Assert.That(Algorithms.FibonacciRecursive(4), Is.EqualTo(3));
            Assert.That(Algorithms.FibonacciRecursive(5), Is.EqualTo(5));
            Assert.That(Algorithms.FibonacciRecursive(6), Is.EqualTo(8));
            Assert.That(Algorithms.FibonacciRecursive(7), Is.EqualTo(13));
            Assert.That(Algorithms.FibonacciRecursive(8), Is.EqualTo(21));
            Assert.That(Algorithms.FibonacciRecursive(9), Is.EqualTo(34));
            Assert.That(Algorithms.FibonacciRecursive(10), Is.EqualTo(55));
        });
    }

    [Test]
    public void FibonacciIterativeTest()
    {
        // TODO: Fix the missing values in the Is.EqualTo() calls
        Assert.Multiple(() =>
        {
            Assert.That(Algorithms.FibonacciIterative(0), Is.EqualTo);
            Assert.That(Algorithms.FibonacciIterative(1), Is.EqualTo);
            Assert.That(Algorithms.FibonacciIterative(2), Is.EqualTo);
            Assert.That(Algorithms.FibonacciIterative(3), Is.EqualTo);
            Assert.That(Algorithms.FibonacciIterative(4), Is.EqualTo);
            Assert.That(Algorithms.FibonacciIterative(5), Is.EqualTo);
            Assert.That(Algorithms.FibonacciIterative(6), Is.EqualTo);
            Assert.That(Algorithms.FibonacciIterative(7), Is.EqualTo);
            Assert.That(Algorithms.FibonacciIterative(8), Is.EqualTo);
            Assert.That(Algorithms.FibonacciIterative(9), Is.EqualTo);
            Assert.That(Algorithms.FibonacciIterative(10), Is.EqualTo);
        });
    }

    [Test]
    public void BinarySearchTest()
    {
        // TODO: Fix the wrong values in the Is.EqualTo() calls
        int[] array = [1, 3, 5, 7, 9, 11, 13, 15, 17, 19];
        Assert.Multiple(() =>
        {
            Assert.That(Algorithms.BinarySearch(array, 1), Is.EqualTo(0));
            Assert.That(Algorithms.BinarySearch(array, 3), Is.EqualTo(1));
            Assert.That(Algorithms.BinarySearch(array, 5), Is.EqualTo(2));
            Assert.That(Algorithms.BinarySearch(array, 7), Is.EqualTo(3));
            Assert.That(Algorithms.BinarySearch(array, 9), Is.EqualTo(4));
            Assert.That(Algorithms.BinarySearch(array, 11), Is.EqualTo(5));
            Assert.That(Algorithms.BinarySearch(array, 13), Is.EqualTo(6));
            Assert.That(Algorithms.BinarySearch(array, 15), Is.EqualTo(7));
            Assert.That(Algorithms.BinarySearch(array, 17), Is.EqualTo(8));
            Assert.That(Algorithms.BinarySearch(array, 19), Is.EqualTo(8));
            Assert.That(Algorithms.BinarySearch(array, 0), Is.EqualTo(-1));
            Assert.That(Algorithms.BinarySearch(array, 2), Is.EqualTo(-1));
            Assert.That(Algorithms.BinarySearch(array, 4), Is.EqualTo(-1));
            Assert.That(Algorithms.BinarySearch(array, 6), Is.EqualTo(-1));
            Assert.That(Algorithms.BinarySearch(array, 8), Is.EqualTo(-1));
            Assert.That(Algorithms.BinarySearch(array, 10), Is.EqualTo(1));
            Assert.That(Algorithms.BinarySearch(array, 12), Is.EqualTo(-1));
            Assert.That(Algorithms.BinarySearch(array, 14), Is.EqualTo(-1));
            Assert.That(Algorithms.BinarySearch(array, 16), Is.EqualTo(-1));
            Assert.That(Algorithms.BinarySearch(array, 18), Is.EqualTo(-1));
            Assert.That(Algorithms.BinarySearch(array, 20), Is.EqualTo(-1));
        });
    }
}