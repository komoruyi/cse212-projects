// Test for adding an element to the queue. This test checks if the queue correctly adds a new element and updates the count.
// Defect Documentation: This feature was prone to edge cases where the queue might exceed its capacity, leading to potential overflow errors.
[Test]
public void AddElementIncreasesCount()
{
    var queue = new TakingTurnsQueue();
    queue.Add("First");
    Assert.AreEqual(1, queue.Count);
}

// Test for removing an element from the queue. This test ensures that elements can be removed properly without affecting the count.
// Defect Documentation: Previous versions had issues with removing elements if the queue was empty; ensure proper exception handling.
[Test]
public void RemoveElementDecreasesCount()
{
    var queue = new TakingTurnsQueue();
    queue.Add("First");
    queue.Remove();
    Assert.AreEqual(0, queue.Count);
}
