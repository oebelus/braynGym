static DoublyLinkedListNode SortedInsert(DoublyLinkedListNode llist, int data)
{
    DoublyLinkedListNode node = new(data);
    DoublyLinkedListNode linked = new(0);
    DoublyLinkedListNode tail = linked;
    while (llist.data < data && llist.next != null) {
        tail.next = llist;
        tail = tail.next;
        llist = llist.next;
    }
    
    if (llist.data < node.data) {
        tail.next = llist;
        llist.next = node;
    }
    else {
        tail.next = node;
        node.next = llist;
    }
    return linked.next ?? node;
}
