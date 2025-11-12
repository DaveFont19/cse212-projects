using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("box", 10);
        priorityQueue.Enqueue("pc", 12);
        priorityQueue.Enqueue("nintendo", 15);
        priorityQueue.Enqueue("laptop", 15);
        var firstRemove = priorityQueue.Dequeue();
        Assert.AreEqual("nintendo", firstRemove);
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 2);
        priorityQueue.Enqueue("E", 3);
        priorityQueue.Enqueue("D", 3);

        var firstRemove = priorityQueue.Dequeue();
        Assert.AreEqual("B", firstRemove);
        var secondRemove = priorityQueue.Dequeue();
        Assert.AreEqual("E", secondRemove);
        var thirdRemove = priorityQueue.Dequeue();
        Assert.AreEqual("D", thirdRemove);
    }

    // Add more test cases as needed below.
}