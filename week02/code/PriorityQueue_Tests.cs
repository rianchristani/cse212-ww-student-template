using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Using 2 high priority index with the same values. 
    public void TestPriorityQueue_1()
    {

        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("First",3);
        priorityQueue.Enqueue("Second", 8);
        priorityQueue.Enqueue("Third", 8);
        priorityQueue.Enqueue("Fourth", 2);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Second", result);
    }

    [TestMethod]
    // Scenario: Only one high priprity index
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("First",4);
        priorityQueue.Enqueue("Second", 5);
        priorityQueue.Enqueue("Third", 6);
        priorityQueue.Enqueue("Fourth", 7);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Fourth", result); 
    }

    // Add more test cases as needed below.
}