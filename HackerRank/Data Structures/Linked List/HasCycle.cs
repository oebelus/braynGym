static bool HasCycle(SinglyLinkedListNode head) {
    List<SinglyLinkedListNode> traversed = new();
    while (head != null) {
        if (!traversed.Contains(head)) traversed.Add(head);
        else return true;
        head = head.next;
    }
    return false;
}
