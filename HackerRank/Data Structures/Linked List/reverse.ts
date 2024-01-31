function reverse(llist: DoublyLinkedListNode): DoublyLinkedListNode {
    let temp: DoublyLinkedListNode | null = null;
    let current: DoublyLinkedListNode | null = llist;
    while (current != null) {
        temp = current.prev;
        current.prev = current.next;
        current.next = temp;
        current = current.prev;
    }
    if (temp != null && temp.prev != null) llist = temp.prev;
    return llist;
}
