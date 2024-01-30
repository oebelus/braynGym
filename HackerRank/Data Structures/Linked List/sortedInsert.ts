function sortedInsert(llist: DoublyLinkedListNode, data: number): DoublyLinkedListNode {
    let node: DoublyLinkedListNode = new DoublyLinkedListNode(data);
    let linked: DoublyLinkedListNode = new DoublyLinkedListNode(0);
    let tail: DoublyLinkedListNode = linked;

    while (llist.data < data && llist.next != undefined) {
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

    return linked.next? linked.next : node;
}
